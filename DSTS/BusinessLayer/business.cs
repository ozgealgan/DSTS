using DSTS.localClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace DSTS.BusinessLayer
{
    public class business
    {
        string conStrig = WebConfigurationManager.ConnectionStrings["."].ConnectionString;

        public void StokEkle(int fakulteId, string dbAdi, int DbAdet, decimal dbFiyat, int dbtur, string dbMarka, string dbModel)
        {           
            using (SqlConnection conn = new SqlConnection(conStrig))
            {
                conn.Open();
                
                SqlCommand cmdd = new SqlCommand("spkayit", conn);
                cmdd.CommandType = CommandType.StoredProcedure;
                cmdd.Parameters.Add(new SqlParameter("@demirbasAdi", dbAdi));
                
                
                cmdd.Parameters.Add(new SqlParameter("@demirbasAdet", DbAdet));
                cmdd.Parameters.Add(new SqlParameter("@demirbasFiyat", dbFiyat));
                cmdd.Parameters.Add(new SqlParameter("@demirbasTur", dbtur));
                cmdd.Parameters.Add(new SqlParameter("@demirbasTarih", DateTime.Now));
                cmdd.Parameters.Add(new SqlParameter("@demirbasMarka", dbMarka));
                cmdd.Parameters.Add(new SqlParameter("@demirbasModel", dbModel));
                cmdd.Parameters.Add(new SqlParameter("@demirbasFakulteId", fakulteId));             
                cmdd.Parameters.Add(new SqlParameter("@demirbasKod", "01.02.01.01"));

                //SqlDataAdapter da = new SqlDataAdapter(cmdd);

                cmdd.CommandTimeout = 600;
                cmdd.ExecuteNonQuery();
                conn.Dispose();
                
                conn.Close();
            }
         
        }

        
        

    }
}