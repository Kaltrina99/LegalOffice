using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.AgreementExtrasDTO;
using LegalOfficeWeb_Models.CaseDTO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository
{
    public class AgreementExtrasRepository : IAgreementExtrasRepository
    {
        private readonly BaseRepository baseRepo;
        public AgreementExtrasRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }

        public async Task<IEnumerable<AgreemeentInvoicePaymentsResponseDTO>> AgreemeentInvoicePayments(AgreementFilterDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_get_AgrInvoicePayments", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();

                        var items = new List<AgreemeentInvoicePaymentsResponseDTO>();
                        while (await reader.ReadAsync())
                        {
                            var item = new AgreemeentInvoicePaymentsResponseDTO();
                            item.Id = int.Parse(reader["Id"].ToString());
                            item.AgreementId = int.Parse(reader["AgreementId"].ToString());
                            item.InvoiceId = int.Parse(reader["InvoiceId"].ToString());
                            item.CollectionID = int.Parse(reader["CollectionID"].ToString());
                            item.ArchiveID = int.Parse(reader["ArchiveID"].ToString());
                            item.Credit = double.Parse(reader["Credit"].ToString());
                            item.CreditInv = reader["Credit"].ToString();
                            item.CreatedUser = int.Parse(reader["CreatedUser"].ToString());
                            item.IsSent = int.Parse(reader["IsSent"].ToString());
                            item.CreatedDate = DateTime.Parse(reader["CreatedDate"].ToString());
                            item.CreatedComment = (reader["CreatedComment"].ToString());
                            item.DocumentPath = reader["DocumentPath"].ToString();
                            item.CreatedUserName = reader["CreatedUserName"].ToString();
                            items.Add(item);
                        }
                        con.Close();
                        return items;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<IEnumerable<AgreementInstallmentResponseDTO>> AgreementInstallmentResponseDTOs(AgreementFilterDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_get_AgrIns", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();

                        var items = new List<AgreementInstallmentResponseDTO>();
                        while (await reader.ReadAsync())
                        {
                            var item = new AgreementInstallmentResponseDTO();
                            item.AgrInsId = int.Parse(reader["AgrInsId"].ToString());
                            item.AgreementId = int.Parse(reader["AgreementId"].ToString());
                            item.CaseId = int.Parse(reader["CaseId"].ToString());
                            item.InsNo = int.Parse(reader["InsNo"].ToString());
                            item.InsTypeId = int.Parse(reader["InsTypeId"].ToString());
                            item.Amount = decimal.Parse(reader["Credit"].ToString());
                            item.CreatedUser = int.Parse(reader["CreatedUser"].ToString());
                            item.DueDate = DateTime.Parse(reader["DueDate"].ToString());
                            item.CreatedDate = DateTime.Parse(reader["CreatedDate"].ToString());
                            item.CreatedUserName = reader["CreatedUserName"].ToString();
                            items.Add(item);
                        }
                        con.Close();
                        return items;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<IEnumerable<AgreementInvoiceResponseDTO>> AgreementInvoices(AgreementFilterDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_get_AgrInv", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();

                        var items = new List<AgreementInvoiceResponseDTO>();
                        while (await reader.ReadAsync())
                        {
                            var item = new AgreementInvoiceResponseDTO();
                            item.Id = int.Parse(reader["Id"].ToString());
                            item.EldebitorId = int.Parse(reader["EldebitorId"].ToString());
                            item.AgreementId = int.Parse(reader["AgreementId"].ToString());
                            item.CaseId = int.Parse(reader["CaseId"].ToString());
                            item.InvoiceId = int.Parse(reader["InvoiceId"].ToString());
                            item.InvoiceIdccp = int.Parse(reader["InvoiceIdccp"].ToString());
                            item.InvoiceIdrl = int.Parse(reader["InvoiceIdrl"].ToString());
                            item.InvoiceAmount = decimal.Parse(reader["InvoiceAmount"].ToString());
                            item.InvoiceAmountInv = decimal.Parse(reader["InvoiceAmountInv"].ToString());
                            item.CreatedUser = int.Parse(reader["CreatedUser"].ToString());
                            item.CreatedDate = DateTime.Parse(reader["CreatedDate"].ToString());
                            item.CreatedUserName = reader["CreatedUserName"].ToString();
                            items.Add(item);
                        }
                        con.Close();
                        return items;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<IEnumerable<AgreementNotificationResponseDTO>> AgreementNotification(AgreementFilterDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_get_AgrNot", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();

                        var items = new List<AgreementNotificationResponseDTO>();
                        while (await reader.ReadAsync())
                        {
                            var item = new AgreementNotificationResponseDTO();
                            item.Id = int.Parse(reader["Id"].ToString());
                            item.AgreementId = int.Parse(reader["AgreementId"].ToString());
                            item.PhoneNr = reader["PhoneNr"].ToString();
                            item.Email = reader["Email"].ToString();
                            item.NotificationText = reader["NotificationText"].ToString();
                            item.CreatedUser = int.Parse(reader["CreatedUser"].ToString());
                            item.IsSent = int.Parse(reader["IsSent"].ToString());
                            item.CreatedDate = DateTime.Parse(reader["CreatedDate"].ToString());
                            item.CreatedUserName = reader["CreatedUserName"].ToString();
                            item.ForCustomer = int.Parse(reader["ForCustomer"].ToString());
                            items.Add(item);
                        }
                        con.Close();
                        return items;
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
