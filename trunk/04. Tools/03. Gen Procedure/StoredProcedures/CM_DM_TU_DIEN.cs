///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'CM_DM_TU_DIEN'
// Generated by LLBLGen v1.21.2003.712 Final on: 12/09/2011, 10:22:11 AM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace trmLLBL
{
	/// <summary>
	/// Purpose: Data Access class for the table 'CM_DM_TU_DIEN'.
	/// </summary>
	public class CM_DM_TU_DIEN : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDecimal		_iD_LOAI_TU_DIEN, _iD_LOAI_TU_DIENOld, _iD;
			private SqlString		_tEN, _gHI_CHU, _mA_TU_DIEN, _tEN_NGAN;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CM_DM_TU_DIEN()
		{
			// Nothing for now.
		}


		/// <summary>
		/// Purpose: Insert method. This method will insert one new row into the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>MA_TU_DIEN</LI>
		///		 <LI>ID_LOAI_TU_DIEN</LI>
		///		 <LI>TEN_NGAN</LI>
		///		 <LI>TEN</LI>
		///		 <LI>GHI_CHU. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_CM_DM_TU_DIEN_Insert]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@MA_TU_DIEN", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _mA_TU_DIEN));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_LOAI_TU_DIEN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_LOAI_TU_DIEN));
				cmdToExecute.Parameters.Add(new SqlParameter("@TEN_NGAN", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tEN_NGAN));
				cmdToExecute.Parameters.Add(new SqlParameter("@TEN", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tEN));
				cmdToExecute.Parameters.Add(new SqlParameter("@GHI_CHU", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _gHI_CHU));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Output, false, 18, 1, "", DataRowVersion.Proposed, _iD));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_iD = (Decimal)cmdToExecute.Parameters["@ID"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("CM_DM_TU_DIEN::Insert::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method. This method will Update one existing row in the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID</LI>
		///		 <LI>MA_TU_DIEN</LI>
		///		 <LI>ID_LOAI_TU_DIEN</LI>
		///		 <LI>TEN_NGAN</LI>
		///		 <LI>TEN</LI>
		///		 <LI>GHI_CHU. May be SqlString.Null</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_CM_DM_TU_DIEN_Update]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));
				cmdToExecute.Parameters.Add(new SqlParameter("@MA_TU_DIEN", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _mA_TU_DIEN));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_LOAI_TU_DIEN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_LOAI_TU_DIEN));
				cmdToExecute.Parameters.Add(new SqlParameter("@TEN_NGAN", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tEN_NGAN));
				cmdToExecute.Parameters.Add(new SqlParameter("@TEN", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tEN));
				cmdToExecute.Parameters.Add(new SqlParameter("@GHI_CHU", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _gHI_CHU));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("CM_DM_TU_DIEN::Update::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'ID_LOAI_TU_DIEN.
		/// This method will Update one or more existing rows in the database. It will reset the field 'ID_LOAI_TU_DIEN' in
		/// all rows which have as value for this field the value as set in property 'ID_LOAI_TU_DIENOld' to 
		/// the value as set in property 'ID_LOAI_TU_DIEN'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_LOAI_TU_DIEN</LI>
		///		 <LI>ID_LOAI_TU_DIENOld</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWID_LOAI_TU_DIENLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_CM_DM_TU_DIEN_UpdateAllWID_LOAI_TU_DIENLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_LOAI_TU_DIEN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_LOAI_TU_DIEN));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_LOAI_TU_DIENOld", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_LOAI_TU_DIENOld));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("CM_DM_TU_DIEN::UpdateAllWID_LOAI_TU_DIENLogic::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method. This method will Delete one existing row in the database, based on the Primary Key.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_CM_DM_TU_DIEN_Delete]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("CM_DM_TU_DIEN::Delete::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method for a foreign key. This method will Delete one or more rows from the database, based on the Foreign Key 'ID_LOAI_TU_DIEN'
		/// </summary>
		/// <returns>True if succeeded, false otherwise. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID_LOAI_TU_DIEN</LI>
		/// </UL>
		/// </remarks>
		public bool DeleteAllWID_LOAI_TU_DIENLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_CM_DM_TU_DIEN_DeleteAllWID_LOAI_TU_DIENLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID_LOAI_TU_DIEN", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD_LOAI_TU_DIEN));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("CM_DM_TU_DIEN::DeleteAllWID_LOAI_TU_DIENLogic::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlDecimal ID
		{
			get
			{
				return _iD;
			}
			set
			{
				SqlDecimal iDTmp = (SqlDecimal)value;
				if(iDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID", "ID can't be NULL");
				}
				_iD = value;
			}
		}


		public SqlString MA_TU_DIEN
		{
			get
			{
				return _mA_TU_DIEN;
			}
			set
			{
				SqlString mA_TU_DIENTmp = (SqlString)value;
				if(mA_TU_DIENTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("MA_TU_DIEN", "MA_TU_DIEN can't be NULL");
				}
				_mA_TU_DIEN = value;
			}
		}


		public SqlDecimal ID_LOAI_TU_DIEN
		{
			get
			{
				return _iD_LOAI_TU_DIEN;
			}
			set
			{
				SqlDecimal iD_LOAI_TU_DIENTmp = (SqlDecimal)value;
				if(iD_LOAI_TU_DIENTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_LOAI_TU_DIEN", "ID_LOAI_TU_DIEN can't be NULL");
				}
				_iD_LOAI_TU_DIEN = value;
			}
		}
		public SqlDecimal ID_LOAI_TU_DIENOld
		{
			get
			{
				return _iD_LOAI_TU_DIENOld;
			}
			set
			{
				SqlDecimal iD_LOAI_TU_DIENOldTmp = (SqlDecimal)value;
				if(iD_LOAI_TU_DIENOldTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_LOAI_TU_DIENOld", "ID_LOAI_TU_DIENOld can't be NULL");
				}
				_iD_LOAI_TU_DIENOld = value;
			}
		}


		public SqlString TEN_NGAN
		{
			get
			{
				return _tEN_NGAN;
			}
			set
			{
				SqlString tEN_NGANTmp = (SqlString)value;
				if(tEN_NGANTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("TEN_NGAN", "TEN_NGAN can't be NULL");
				}
				_tEN_NGAN = value;
			}
		}


		public SqlString TEN
		{
			get
			{
				return _tEN;
			}
			set
			{
				SqlString tENTmp = (SqlString)value;
				if(tENTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("TEN", "TEN can't be NULL");
				}
				_tEN = value;
			}
		}


		public SqlString GHI_CHU
		{
			get
			{
				return _gHI_CHU;
			}
			set
			{
				SqlString gHI_CHUTmp = (SqlString)value;
				if(gHI_CHUTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("GHI_CHU", "GHI_CHU can't be NULL");
				}
				_gHI_CHU = value;
			}
		}
		#endregion
	}
}