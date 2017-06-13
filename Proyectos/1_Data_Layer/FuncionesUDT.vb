Imports System.Reflection
Imports SBOAddonProject1

Public Class FuncionesUDT

    Public Shared oCompany As SAPbobsCOM.Company = DConectarAplicacion.oCompanyPS

    Public Shared Function GetNextCode(SBO_Company As SAPbobsCOM.Company, ByVal UDT_Name As String) As Integer
        Dim nProx As Integer = 0
        Try

            Dim oRecorset As SAPbobsCOM.Recordset = SBO_Company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            Dim sql As String = "select isnull(max(CAST(Code as int)),0)+1 as Proximo from [@" + UDT_Name + "]"

            oRecorset.DoQuery(sql)
            nProx = oRecorset.Fields.Item("Proximo").Value
        Catch ex As Exception

        End Try

        Return nProx
    End Function

    Public Shared Function GetCodeUDT(Table As String, WhereCondition As String, Optional DB_Company As String = "") As Integer
        Dim nCode As Integer = 0
        Dim SBO_Company As SAPbobsCOM.Company = oCompany
        Try
            'get company service
            FuncionesUDT.Connect_Company(SBO_Company)

            If DB_Company.Trim.Length > 0 Then
                Dim oConectarAplicacion As New DConectarAplicacion()
                SBO_Company = oConectarAplicacion.Conectar_Empresa(SBO_Company, DB_Company)
            End If

            Dim oRecordSet As SAPbobsCOM.Recordset = SBO_Company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            Dim sql As String = "select Code from [@" + Table + "] " + WhereCondition
            oRecordSet.DoQuery(sql)
            nCode = oRecordSet.Fields.Item("Code").Value
        Catch ex As Exception

        End Try

        Return nCode
    End Function

    Public Shared Function LoadObjectInfoFromRecordset(ByRef Objeto As Object, Table As String, WhereCondition As String) As String
        Dim rpta As String = "N"
        Dim SBO_Company As SAPbobsCOM.Company = oCompany
        Try
            FuncionesUDT.Connect_Company(SBO_Company)

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

        Catch ex As Exception
        End Try

        Return rpta
    End Function

    Public Shared Function InsertRecord(ByVal UDT_Name As String, ByVal Objeto As Object, Optional DB_Company As String = "") As String
        Dim rpta As String = "N"
        Dim SBO_Company As SAPbobsCOM.Company = oCompany
        Try
            FuncionesUDT.Connect_Company(SBO_Company)

            If DB_Company.Trim.Length > 0 Then
                Dim oConectarAplicacion As New DConectarAplicacion()
                SBO_Company = oConectarAplicacion.Conectar_Empresa(SBO_Company, DB_Company)
            End If

            Dim UDT As SAPbobsCOM.UserTable

            UDT = SBO_Company.UserTables.Item(UDT_Name)
            UDT.Code = FuncionesUDT.GetNextCode(SBO_Company, UDT_Name).ToString
            UDT.Name = UDT.Code

            For Each propiedad As PropertyInfo In Objeto.GetType.GetProperties
                Try
                    Dim tipoPropiedad As String = propiedad.PropertyType.Name
                    Dim NombrePropiedad As String = propiedad.Name
                    Dim valorPropiedad = propiedad.GetValue(Objeto, Nothing)
                    UDT.UserFields.Fields.Item(NombrePropiedad).Value = valorPropiedad
                Catch ex As Exception
                    rpta = "N"
                End Try
            Next

            Dim ErrCode = UDT.Add()
            If ErrCode <> 0 Then
                rpta = "N"
            Else
                rpta = "S"
            End If

        Catch ex As Exception
        End Try
        Return rpta

    End Function

    Public Shared Function UpdateRecord(ByVal UDT_Name As String, ByVal Objeto As Object, ByVal CodigoObj As String, Optional DB_Company As String = "") As String
        Dim SBO_Company As SAPbobsCOM.Company = oCompany

        Dim rpta As String = "N"

        Try
            FuncionesUDT.Connect_Company(SBO_Company)

            If DB_Company.Trim.Length > 0 Then
                Dim oConectarAplicacion As New DConectarAplicacion()
                SBO_Company = oConectarAplicacion.Conectar_Empresa(SBO_Company, DB_Company)
            End If

            Dim UDT As SAPbobsCOM.UserTable

            UDT = SBO_Company.UserTables.Item(UDT_Name)

            UDT.GetByKey(CodigoObj)
            ' Update UDO record
            For Each propiedad As PropertyInfo In Objeto.GetType.GetProperties
                Try
                    Dim tipoPropiedad As String = propiedad.PropertyType.Name
                    Dim NombrePropiedad As String = propiedad.Name
                    Dim valorPropiedad = propiedad.GetValue(Objeto, Nothing)
                    UDT.UserFields.Fields.Item(NombrePropiedad).Value = valorPropiedad
                Catch ex As Exception
                    rpta = "N"
                End Try
            Next

            Dim ErrCode = UDT.Update()
            If ErrCode <> 0 Then
                rpta = "N"
            Else
                rpta = "S"
            End If

        Catch ex As Exception
        End Try
        Return rpta
    End Function

    Public Shared Function DeleteRecord(ByVal UDT_Name As String, ByVal CodigoObj As String, Optional DB_Company As String = "") As String
        Dim SBO_Company As SAPbobsCOM.Company = oCompany

        Dim rpta As String = "N"
        Try
            FuncionesUDT.Connect_Company(SBO_Company)

            If DB_Company.Trim.Length > 0 Then
                Dim oConectarAplicacion As New DConectarAplicacion()
                SBO_Company = oConectarAplicacion.Conectar_Empresa(SBO_Company, DB_Company)
            End If

            Dim UDT As SAPbobsCOM.UserTable

            UDT = SBO_Company.UserTables.Item(UDT_Name)

            UDT.GetByKey(CodigoObj)

            Dim ErrCode = UDT.Remove()
            If ErrCode <> 0 Then
                rpta = "N"
            Else
                rpta = "S"
            End If
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
