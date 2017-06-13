Imports System.Reflection
Imports SBOAddonProject1

Public Class FuncionesUDO

    Public Shared oCompany As SAPbobsCOM.Company = DConectarAplicacion.oCompanyPS

    Public Shared Function GetNextCode(ByVal UDO_Name As String) As Integer
        Dim nProx As Integer = 0
        Dim SBO_Company As SAPbobsCOM.Company = oCompany
        Try
            'get company service
            FuncionesUDO.Connect_Company(SBO_Company)

            Dim oRecorset As SAPbobsCOM.Recordset = SBO_Company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            Dim sql As String = "select isnull(max(CAST(Code as int)),0)+1 as Proximo from [@" + UDO_Name + "]"
            oRecorset.DoQuery(sql)
            nProx = oRecorset.Fields.Item("Proximo").Value

            System.Runtime.InteropServices.Marshal.ReleaseComObject(oRecorset)

        Catch ex As Exception

        End Try

        Return nProx
    End Function

    Public Shared Function GetCodeUDO(Table As String, WhereCondition As String, Optional DB_Company As String = "") As Integer
        Dim nCode As Integer = 0
        Dim SBO_Company As SAPbobsCOM.Company = oCompany
        Try
            'get company service
            FuncionesUDO.Connect_Company(SBO_Company)

            If DB_Company.Trim.Length > 0 Then
                Dim oConectarAplicacion As New DConectarAplicacion()
                SBO_Company = oConectarAplicacion.Conectar_Empresa(SBO_Company, DB_Company)
            End If

            Dim oRecordSet As SAPbobsCOM.Recordset = SBO_Company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            Dim sql As String = "select Code from [@" + Table + "] " + WhereCondition
            oRecordSet.DoQuery(sql)
            nCode = oRecordSet.Fields.Item("Code").Value

            System.Runtime.InteropServices.Marshal.ReleaseComObject(oRecordSet)

        Catch ex As Exception

        End Try

        Return nCode
    End Function

    Public Shared Function LoadObjectInfoFromRecordset(ByRef Objeto As Object, Table As String, WhereCondition As String) As String
        Dim rpta As String = "N"
        Dim SBO_Company As SAPbobsCOM.Company = oCompany
        Try
            FuncionesUDO.Connect_Company(SBO_Company)

            Dim oRecordSet As SAPbobsCOM.Recordset = SBO_Company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

            Dim sql As String = "select * from [" + Table + "] " + WhereCondition
            oRecordSet.DoQuery(sql)

            If oRecordSet.RecordCount > 0 Then
                rpta = "S"
                oRecordSet.MoveFirst()
                For Each propiedad As PropertyInfo In Objeto.GetType.GetProperties
                    Try
                        Dim tipoPropiedad As String = propiedad.PropertyType.Name
                        Dim NombrePropiedad As String = propiedad.Name
                        Dim valorPropiedad = propiedad.GetValue(Objeto, Nothing)
                        propiedad.SetValue(Objeto, Convert.ChangeType(oRecordSet.Fields.Item(NombrePropiedad).Value, propiedad.PropertyType), Nothing)
                    Catch ex As Exception
                        rpta = "N"
                    End Try
                Next
            End If

            System.Runtime.InteropServices.Marshal.ReleaseComObject(oRecordSet)

        Catch ex As Exception
        End Try

        Return rpta
    End Function

    Public Shared Function InsertRecord(ByVal UDO_Name As String, ByVal Objeto As Object, ByVal UDO_Child As String, ByVal DetalleObjeto As List(Of Object), Optional DB_Company As String = "") As String
        Dim SBO_Company As SAPbobsCOM.Company = oCompany
        Dim oGeneralService As SAPbobsCOM.GeneralService
        Dim oGeneralData As SAPbobsCOM.GeneralData
        Dim oChild As SAPbobsCOM.GeneralData
        Dim oChildren As SAPbobsCOM.GeneralDataCollection
        'SAPbobsCOM.GeneralDataParams oGeneralParams;
        Dim oCompService As SAPbobsCOM.CompanyService
        Dim rpta As String = "N"
        Try
            'get company service
            FuncionesUDO.Connect_Company(SBO_Company)

            If DB_Company.Trim.Length > 0 Then
                Dim oConectarAplicacion As New DConectarAplicacion()
                SBO_Company = oConectarAplicacion.Conectar_Empresa(SBO_Company, DB_Company)
            End If

            oCompService = SBO_Company.GetCompanyService
            'SBO_Company.StartTransaction();
            oGeneralService = oCompService.GetGeneralService(UDO_Name)
            oGeneralData = CType(oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralData), SAPbobsCOM.GeneralData)
            'Setting Data to Master Data Table Fields
            oGeneralData.SetProperty("Code", FuncionesUDO.GetNextCode(UDO_Name).ToString)
            'Recorrer el Objeto y tomar Nombre y Valor de propiedades y asignarlas 
            For Each propiedad As PropertyInfo In Objeto.GetType.GetProperties
                Try
                    Dim tipoPropiedad As String = propiedad.PropertyType.Name
                    Dim NombrePropiedad As String = propiedad.Name
                    Dim valorPropiedad = propiedad.GetValue(Objeto, Nothing)
                    oGeneralData.SetProperty(NombrePropiedad, valorPropiedad)
                Catch ex As Exception

                End Try

            Next
            '  Handle child rows
            If DetalleObjeto.Any Then
                oChildren = oGeneralData.Child(UDO_Child)
                For Each det As Object In DetalleObjeto
                    ' Create data for rows in the child table
                    oChild = oChildren.Add
                    For Each dPropiedad As PropertyInfo In det.GetType.GetProperties
                        Try
                            Dim tipoPropiedad As String = dPropiedad.PropertyType.Name
                            Dim NombrePropiedad As String = dPropiedad.Name
                            Dim valorPropiedad = dPropiedad.GetValue(det, Nothing)
                            oChild.SetProperty(NombrePropiedad, valorPropiedad)
                        Catch ex As Exception

                        End Try

                    Next
                Next
                Try
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oChildren)
                Catch ex As Exception
                End Try
            End If

            'if(!DT_CHILD.IsEmpty)
            '{
            '    oChildren = oGeneralData.Child("SM_MOR1");
            '    for (int i = 0; i <= DT_CHILD.Rows.Count - 1; i++)
            '    {
            '    // Create data for rows in the child table
            '        oChild = oChildren.Add();
            '        for (int j = 0; j <= DT_CHILD.Columns.Count - 1; j++)
            '        {
            '            string nombreColumna = DT_CHILD.Columns.Item(j).Name;
            '            var valorColumna = DT_CHILD.GetValue(j, i);
            '            oChild.SetProperty(nombreColumna, valorColumna);
            '        }
            '    }
            '}
            'Attempt to Add the Record
            oGeneralService.Add(oGeneralData)
            rpta = "S"

            
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oGeneralData)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oGeneralService)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oCompService)


        Catch ex As Exception

        Finally
            If SBO_Company.InTransaction Then
                SBO_Company.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
            End If

        End Try

        Return rpta
        'try
        '{
        '    Type c_typo =  Objeto.GetType();
        '    PropertyInfo[] c_propiedades = c_typo.GetProperties();
        '    //var valor = c_propiedades.GetValue(Objeto);
        '    foreach (PropertyInfo propiedad in Objeto.GetType().GetProperties())
        '    {
        '        string tipoPropiedad = propiedad.PropertyType.Name;
        '        string NombrePropiedad = propiedad.Name;
        '        var valorPropiedad = propiedad.GetValue(Objeto, null);
        '    }
        '}
        'catch (Exception){}
    End Function

    Public Shared Function UpdateRecordHead(ByVal UDO_Name As String, ByVal Objeto As Object, ByVal CodigoObj As String) As String
        Dim oGeneralService As SAPbobsCOM.GeneralService = Nothing
        Dim oGeneralData As SAPbobsCOM.GeneralData = Nothing
        Dim oGeneralParams As SAPbobsCOM.GeneralDataParams = Nothing
        Dim sCmp As SAPbobsCOM.CompanyService = Nothing
        Dim SBO_Company As SAPbobsCOM.Company = oCompany

        Dim rpta As String = "N"
        '  This function updates only parent record.
        '  Child records remain as is.

        Try
            FuncionesUDO.Connect_Company(SBO_Company)

            sCmp = SBO_Company.GetCompanyService

            ' Get a handle UDO
            oGeneralService = sCmp.GetGeneralService(UDO_Name)
            ' Get UDO record
            oGeneralParams = CType(oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralDataParams), SAPbobsCOM.GeneralDataParams)
            oGeneralParams.SetProperty("Code", CodigoObj)
            oGeneralData = oGeneralService.GetByParams(oGeneralParams)
            ' Update UDO record
            For Each propiedad As PropertyInfo In Objeto.GetType.GetProperties
                Try
                    Dim tipoPropiedad As String = propiedad.PropertyType.Name
                    Dim NombrePropiedad As String = propiedad.Name
                    Dim valorPropiedad = propiedad.GetValue(Objeto, Nothing)
                    oGeneralData.SetProperty(NombrePropiedad, valorPropiedad)
                Catch ex As Exception

                End Try

            Next
            oGeneralService.Update(oGeneralData)
            rpta = "S"

            System.Runtime.InteropServices.Marshal.ReleaseComObject(oGeneralData)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oGeneralService)

        Catch ex As Exception

        End Try

        Return rpta
    End Function

    Public Shared Function DeleteRecord(ByVal UDO_Name As String, ByVal CodigoObj As String) As String
        Dim oGeneralService As SAPbobsCOM.GeneralService = Nothing
        Dim oGeneralData As SAPbobsCOM.GeneralData = Nothing
        Dim oGeneralParams As SAPbobsCOM.GeneralDataParams = Nothing
        Dim sCmp As SAPbobsCOM.CompanyService = Nothing
        Dim SBO_Company As SAPbobsCOM.Company = oCompany

        Dim rpta As String = "N"
        Try
            FuncionesUDO.Connect_Company(SBO_Company)

            sCmp = SBO_Company.GetCompanyService
            ' Get a handle to the SM_MOR UDO
            oGeneralService = sCmp.GetGeneralService(UDO_Name)
            ' Delete UDO record
            oGeneralParams = CType(oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralDataParams), SAPbobsCOM.GeneralDataParams)
            oGeneralParams.SetProperty("Code", CodigoObj)
            oGeneralData = oGeneralService.GetByParams(oGeneralParams)
            oGeneralService.Delete(oGeneralParams)
            rpta = "S"

            System.Runtime.InteropServices.Marshal.ReleaseComObject(oGeneralData)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oGeneralService)

        Catch ex As Exception

        End Try

        Return rpta
    End Function

    Private Shared Sub Connect_Company(ByRef SBO_Company As SAPbobsCOM.Company)
        If Not SBO_Company.Connected Then
            Dim oConectarAplicacion As New DConectarAplicacion()
            oConectarAplicacion.Conectar_Aplicacion()
            SBO_Company = oConectarAplicacion.oCompany
        End If
    End Sub

End Class


