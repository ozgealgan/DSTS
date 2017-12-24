﻿using DSTS.localClass;
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
        string conStrig = WebConfigurationManager.ConnectionStrings["Local_DatabaseConnection"].ConnectionString;

        public void StokEkle(string dbAdi, int DbAdet, decimal dbFiyat, int dbtur)
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
                cmdd.Parameters.Add(new SqlParameter("@demirbasMarka", "örnekmarka"));
                cmdd.Parameters.Add(new SqlParameter("@demirbasModel", "örnekmodel"));

                cmdd.Parameters.Add(new SqlParameter("@demirbasKod", "01.02.01.01"));

                SqlDataAdapter da = new SqlDataAdapter(cmdd);

                cmdd.CommandTimeout = 600;
                cmdd.ExecuteNonQuery();
               // object o = cmdd.ExecuteScalar();
                conn.Dispose();
                
                conn.Close();
            }
         
        }

		public List<localDemirbas> PersoneleGoreAra(string personelAdi)
		{
			List<localDemirbas> ld = new List<localDemirbas>();
			using (SqlConnection conn = new SqlConnection(conStrig))
			{
				conn.Open();
				SqlCommand cmdd = new SqlCommand("spPersoneleGoreAra", conn);
				cmdd.Parameters.Add(new SqlParameter("@personelAdi", personelAdi));

				cmdd.CommandTimeout = 600;
				cmdd.CommandType = CommandType.StoredProcedure;
				SqlDataReader rd = cmdd.ExecuteReader();
				if (rd.HasRows == true)
				{
					while (rd.Read())
					{
						localDemirbas d = new localDemirbas();
						d.odaAdi = rd["odaAdi"].ToString();
						d.demirbasKod = rd["demirbasKodu"].ToString();
						d.demirbasAdi = rd["demirbasAdi"].ToString();
						d.demirbasMarka = rd["marka"].ToString();
						d.demirbasModel = rd["model"].ToString();
						d.adet = (int)rd["adet"];
						ld.Add(d);
					}
				}
				conn.Dispose();
				conn.Close();
			}
			return ld;
		}

		public localpersonel spOdayaGorePersonel(string odaAdi)
		{
			localpersonel lp = new localpersonel();

			using (SqlConnection conn = new SqlConnection(conStrig))
			{
				conn.Open();
				SqlCommand cmdd = new SqlCommand("spOdayaGorePersonel", conn);
				cmdd.Parameters.Add(new SqlParameter("@odaAdi", odaAdi));

				cmdd.CommandTimeout = 600;
				cmdd.CommandType = CommandType.StoredProcedure;
				SqlDataReader rd = cmdd.ExecuteReader();
				if (rd.HasRows == true)
				{
					rd.Read();
					lp.personelAdi = rd["personelAdi"].ToString();
					
				}
				conn.Dispose();
				conn.Close();
			}
			return lp;
		}

		public List<localDemirbas> spOdayaGoreDemirbas(string odaAdi)
		{
			List<localDemirbas> ld = new List<localDemirbas>();
			using (SqlConnection conn = new SqlConnection(conStrig))
			{
				conn.Open();
				SqlCommand cmdd = new SqlCommand("spOdayaGoreDemirbas", conn);
				cmdd.Parameters.Add(new SqlParameter("@odaAdi", odaAdi));

				cmdd.CommandTimeout = 600;
				cmdd.CommandType = CommandType.StoredProcedure;
				SqlDataReader rd = cmdd.ExecuteReader();
				if (rd.HasRows == true)
				{
					while(rd.Read())
					{
						localDemirbas d = new localDemirbas();
						d.demirbasKod= rd["demirbasKodu"].ToString();
						d.demirbasAdi = rd["demirbasAdi"].ToString();
						d.tur = rd["turAdi"].ToString();
						d.adet=(int)rd["adet"];
						ld.Add(d);
					}
				}
				conn.Dispose();
				conn.Close();
			}
			return ld;
		}

		public List<localDemirbas> spDemirbasAdinaGoreAra(string demirbasAdi)
		{
			List<localDemirbas> ld = new List<localDemirbas>();
			using (SqlConnection conn = new SqlConnection(conStrig))
			{
				conn.Open();
				SqlCommand cmdd = new SqlCommand("spDemirbasAdinaGoreAra", conn);
				cmdd.Parameters.Add(new SqlParameter("@demirbasAdi", demirbasAdi));

				cmdd.CommandTimeout = 600;
				cmdd.CommandType = CommandType.StoredProcedure;
				SqlDataReader rd = cmdd.ExecuteReader();
				if (rd.HasRows == true)
				{
					while (rd.Read())
					{
						localDemirbas d = new localDemirbas();
						d.demirbasKod = rd["demirbasKodu"].ToString();
						d.demirbasAdi = rd["demirbasAdi"].ToString();
						d.demirbasAdet = (int) rd["demirbasAdet"];
						d.tur = rd["turAdi"].ToString();
						d.demirbasFiyat = (decimal) rd["fiyat"];
						d.demirbasTarih = Convert.ToDateTime(rd["alimTarihi"]);
						d.odaAdi=rd["odaAdi"].ToString();
						d.adet = (int)rd["adet"];
						ld.Add(d);
					}
				}
				conn.Dispose();
				conn.Close();
			}
			return ld;
		}

		public List<localDemirbas> spTuruneGoreAra(string turAdi)
		{
			List<localDemirbas> ld = new List<localDemirbas>();
			using (SqlConnection conn = new SqlConnection(conStrig))
			{
				conn.Open();
				SqlCommand cmdd = new SqlCommand("spTuruneGoreAra", conn);
				cmdd.Parameters.Add(new SqlParameter("@turAdi", turAdi));

				cmdd.CommandTimeout = 600;
				cmdd.CommandType = CommandType.StoredProcedure;
				SqlDataReader rd = cmdd.ExecuteReader();
				if (rd.HasRows == true)
				{
					while (rd.Read())
					{
						localDemirbas d = new localDemirbas();
						d.demirbasKod = rd["demirbasKodu"].ToString();
						d.demirbasAdi = rd["demirbasAdi"].ToString();
						d.demirbasAdet = (int)rd["demirbasAdet"];
						d.tur = rd["turAdi"].ToString();
						d.demirbasFiyat = (decimal)rd["fiyat"];
						d.demirbasTarih = Convert.ToDateTime(rd["alimTarihi"]);
						d.odaAdi = rd["odaAdi"].ToString();
						d.adet = (int)rd["adet"];
						ld.Add(d);
					}
				}
				conn.Dispose();
				conn.Close();
			}
			return ld;
		}

		public List<localDemirbas> spFiyatınaGoreAra(string fiyat)
		{
			List<localDemirbas> ld = new List<localDemirbas>();
			using (SqlConnection conn = new SqlConnection(conStrig))
			{
				conn.Open();
				SqlCommand cmdd = new SqlCommand("spFiyatınaGoreAra", conn);
				cmdd.Parameters.Add(new SqlParameter("@fiyat", fiyat));

				cmdd.CommandTimeout = 600;
				cmdd.CommandType = CommandType.StoredProcedure;
				SqlDataReader rd = cmdd.ExecuteReader();
				if (rd.HasRows == true)
				{
					while (rd.Read())
					{
						localDemirbas d = new localDemirbas();
						d.demirbasKod = rd["demirbasKodu"].ToString();
						d.demirbasAdi = rd["demirbasAdi"].ToString();
						d.demirbasAdet = (int)rd["demirbasAdet"];
						d.tur = rd["turAdi"].ToString();
						d.demirbasFiyat = (decimal)rd["fiyat"];
						d.demirbasTarih = Convert.ToDateTime(rd["alimTarihi"]);
						d.odaAdi = rd["odaAdi"].ToString();
						d.adet = (int)rd["adet"];
						ld.Add(d);
					}
				}
				conn.Dispose();
				conn.Close();
			}
			return ld;
		}

		public List<localDemirbas> spTariheGoreAra(string tarih)
		{
			List<localDemirbas> ld = new List<localDemirbas>();
			using (SqlConnection conn = new SqlConnection(conStrig))
			{
				conn.Open();
				SqlCommand cmdd = new SqlCommand("spTariheGoreAra", conn);
				cmdd.Parameters.Add(new SqlParameter("@tarih", tarih));

				cmdd.CommandTimeout = 600;
				cmdd.CommandType = CommandType.StoredProcedure;
				SqlDataReader rd = cmdd.ExecuteReader();
				if (rd.HasRows == true)
				{
					while (rd.Read())
					{
						localDemirbas d = new localDemirbas();
						d.demirbasKod = rd["demirbasKodu"].ToString();
						d.demirbasAdi = rd["demirbasAdi"].ToString();
						d.demirbasAdet = (int)rd["demirbasAdet"];
						d.tur = rd["turAdi"].ToString();
						d.demirbasFiyat = (decimal)rd["fiyat"];
						d.demirbasTarih = Convert.ToDateTime(rd["alimTarihi"]);
						d.odaAdi = rd["odaAdi"].ToString();
						d.adet = (int)rd["adet"];
						ld.Add(d);
					}
				}
				conn.Dispose();
				conn.Close();
			}
			return ld;
		}

	}

}
