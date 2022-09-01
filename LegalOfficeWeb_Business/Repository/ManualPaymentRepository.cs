using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseDTO;
using LegalOfficeWeb_Models.ManualPaymentDTO;
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
    public class ManualPaymentRepository : IManualPaymentRepository
    {
        private readonly BaseRepository baseRepo;
        public ManualPaymentRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }
        public async Task CUDManualPayment(CUDManualPaymentDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("RL_trn_IUDManualPayment", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_PaymentId", objDTO.PaymentId);
                        cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
                        cmd.Parameters.AddWithValue("@prp_InvoiceID", objDTO.InvoiceId);
                        cmd.Parameters.AddWithValue("@prp_CollectionID", objDTO.CollectionId);
                        cmd.Parameters.AddWithValue("@prp_Credit", objDTO.Credit);
                        cmd.Parameters.AddWithValue("@prp_Comment", objDTO.Comment);
                        cmd.Parameters.AddWithValue("@prp_DocName", objDTO.DocName);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", objDTO.PaymentId);

                        await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        await Task.CompletedTask;
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
