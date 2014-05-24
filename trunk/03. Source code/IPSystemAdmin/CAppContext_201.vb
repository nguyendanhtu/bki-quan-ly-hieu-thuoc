Option Explicit On
Option Strict On

Imports IP.Core.IPCommon
Imports IP.Core.IPUserService
Imports IP.Core.IPData

'Imports eSchool.eSchoolData
'Imports eSchool.eSchoolUserService

#Region "Nhiệm vụ của Class"
'************************************************************************
'* Phục vụ lấy dữ liệu đặc trưng cho ứng dụng
'*
'************************************************************************
#End Region

Public Class CAppContext_201
    Implements IControlerControl

#Region "Variables"
    Private Shared m_us_user As US_HT_NGUOI_SU_DUNG
    Private Shared m_strRunMode As String
    Private Shared m_dsDecentralization As New DS_HT_PHAN_QUYEN_DETAIL
#End Region

#Region "Public interface"
    Public Shared Sub LoadDecentralizationByUserLogin()
        Dim v_us As New US_HT_PHAN_QUYEN_DETAIL
        m_dsDecentralization.Clear()
        v_us.FillDatasetByUserLogin(m_dsDecentralization, CAppContext_201.getCurrentUserName())
    End Sub
    Public Function CanUseControl(ByVal ip_strFormName As String, ByVal ip_strControlName As String, ByVal ip_strControlType As String) As Boolean Implements IPCommon.IControlerControl.CanUseControl
        Return CAppContext_201.CanUseThisControl(ip_strFormName, ip_strControlName, ip_strControlType)
    End Function

    Public Shared Function IsHavingQuyen(ByVal i_str_ma_quyen As String) As Boolean
        Return US_HT_NGUOI_SU_DUNG.IsHavingMA_QUYEN( _
           CAppContext_201.getCurrentUserID() _
           , i_str_ma_quyen)

    End Function



    Public Shared Sub InitializeContext(ByVal i_LoginInfo As CLoginInformation_302)
        '*****************************************************************
        '* Init context 
        '* 1. các giá trị thường dùng trong hệ thống
        '* 2. load phân quyền hệ thống về 
        '* 3. Các biến môi trường khác
        '****************************************************************
        '* 1. các giá trị thường dùng trong hệ thống
        '        Debug.Assert(m_strCurrentUserName <> "")
        Try

            m_us_user = i_LoginInfo.m_us_user
            '* 2. load phân quyền hệ thống về 
            '* 3. Các biến môi trường khác
            Dim v_configReader As New System.Configuration.AppSettingsReader
            m_strRunMode = v_configReader.GetValue("RUN_MODE", IPConstants.C_StringType).ToString()
            v_configReader = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function getCurentDate() As DateTime
        '*****************************************************************
        '*  Gọi để lấy ngày hiện tại
        '***********************************************************************
        Return System.DateTime.Now.Date
    End Function

    Public Shared Function getCurrentUserName() As String
        Return m_us_user.strTEN_TRUY_CAP
    End Function

    Public Shared Function getCurrentUser() As String
        Return m_us_user.strTEN
    End Function

    Public Shared Function getCurrentUserID() As Decimal
        Return m_us_user.dcID
    End Function

    Public Shared Function getRunMode() As String
        Return m_strRunMode
    End Function

    Public Shared Function getAppPath() As String
        Return AppDomain.CurrentDomain.SetupInformation.ApplicationBase
    End Function

    Public Shared Function get_DefaultReportRootPath() As String
        Dim v_strRootPath As String
        v_strRootPath = Application.StartupPath
        'v_strRootPath += "\..\.."
        v_strRootPath += "\Reports"
        Return v_strRootPath
    End Function

    Public Shared Function checkLicense() As Boolean

    End Function
#End Region


#Region "Private Methods"
    Private Shared Sub LoadDecentralization(ByVal ip_dsDecentralization As DS_HT_PHAN_QUYEN_DETAIL)
        m_dsDecentralization = ip_dsDecentralization
    End Sub

    Public Shared Function CanUseThisControl(ip_strFormName As String, ip_strControlName As String, ip_strControlType As String) As Boolean
        Dim v_us_v_ht_phan_quyen As New US_V_HT_PHAN_QUYEN()
        Dim v_ds_v_ht_phan_quyen As New DS_V_HT_PHAN_QUYEN()
        Dim v_sp As New CStoredProc("pr_ht_phan_quyen_count")
        v_sp.addDecimalInputParam("@ip_dc_id_user", CAppContext_201.getCurrentUserID())
        v_sp.addNVarcharInputParam("@ip_str_form_name", ip_strFormName)
        v_sp.addNVarcharInputParam("@ip_str_control_name", ip_strControlName)
        v_sp.addNVarcharInputParam("@ip_str_control_type", ip_strControlType)
        v_sp.fillDataSetByCommand(v_us_v_ht_phan_quyen, v_ds_v_ht_phan_quyen)
        If v_ds_v_ht_phan_quyen.V_HT_PHAN_QUYEN.Count > 0 Then
            Return True
        End If
        Return False
    End Function
#End Region
End Class

