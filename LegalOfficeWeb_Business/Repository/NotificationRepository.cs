using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseNotificationDTO;
using LegalOfficeWeb_Models.ReclaimLossesDTO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationResponseDTO = LegalOfficeWeb_Models.CaseNotificationDTO.NotificationResponseDTO;

namespace LegalOfficeWeb_Business.Repository
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly BaseRepository baseRepo;
        public NotificationRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }
        public async Task<NotificationResponseDTO> CUDRLCaseNotification(CUDNotificationDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("RL_trn_IUDCaseNotification", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_CaseHistoryID", objDTO.CaseHistoryID);
                        cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
                        cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
                        cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
                        cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
                        cmd.Parameters.AddWithValue("@prp_WaitingDays", objDTO.WaitingDay);
                        cmd.Parameters.AddWithValue("@prp_InvoiceIDs", objDTO.InvoiceIDs);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", objDTO.ProcessType);

                        var r = await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new NotificationResponseDTO()
                        {
                            CaseId = objDTO.CaseId,
                            CaseHistoryId = objDTO.CaseHistoryID,
                            CustomerName = objDTO.CustomerName,
                            PhoneNr = objDTO.PhoneNr
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<NotificationResponseDTO> GetRLCaseNotification(NotificationDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_get_CaseNotifications", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();


                        var item = new NotificationResponseDTO();
                        while (await reader.ReadAsync())
                        {
                            item.CaseId = int.Parse(reader["CaseID"].ToString());
                            item.CaseHistoryId = int.Parse(reader["CaseHistoryID"].ToString());
                            item.Cnid = int.Parse(reader["Cnid"].ToString());
                            item.CustomerName = reader["CustomerName"].ToString();
                            item.IdentityNr = int.Parse(reader["IdentityNr"].ToString());
                            item.PhoneNr = reader["PhoneNr"].ToString();
                        }
                        con.Close();
                        return item;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<NotificationInvoiceDTO> GetRLCaseNotificationInvioce(NotificationDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_get_CaseNotInvoices", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();


                        var item = new NotificationInvoiceDTO();
                        while (await reader.ReadAsync())
                        {
                            item.CaseId = int.Parse(reader["CaseID"].ToString());
                            item.CaseHistoryId = int.Parse(reader["CaseHistoryID"].ToString());
                            item.Cnid = int.Parse(reader["Cnid"].ToString());
                            item.InvoiceAmount = decimal.Parse(reader["InvoiceAmount"].ToString());
                            item.InvoiceAmountInv = decimal.Parse(reader["InvoiceAmountInv"].ToString());
                            item.InvoiceIdccp = int.Parse(reader["InvoiceIdccp"].ToString());
                            item.InvoiceIdrl = reader["InvoiceIdrl"].ToString();
                        }
                        con.Close();
                        return item;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
