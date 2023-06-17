using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Common;
using System.Data.SqlClient;
using DataHelper;

namespace SALES
{
    public static class BL_Sales
    {
        public static DataTable Get_Taxs()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("ID");
            dt.Columns.Add("TAX_PERC");

            try
            {
                dr = dt.NewRow();
                dr["ID"] = 0;
                dr["TAX_PERC"] = 0;
                dt.Rows.Add(dr);
                dr = dt.NewRow();
                dr["ID"] = 1;
                dr["TAX_PERC"] = 5;
                dt.Rows.Add(dr);
                dr = dt.NewRow();
                dr["ID"] = 2;
                dr["TAX_PERC"] = 18;
                dt.Rows.Add(dr);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static long Create_Sale(DataTable SaleMaster, DataTable SaleDetails)
        {
            var response = new AppResponse(ResponseStatus.FAILURE);
            long saleId = 0;
            try
            {
                List<SqlParameter> lstInParam = new List<SqlParameter>();
                List<SqlParameter> lstOutParam = new List<SqlParameter>();

                lstInParam.Add(new SqlParameter("@P_CUST_NAME", SaleMaster.Rows[0]["CUSTOMER_NAME"].ToString()));
                lstInParam.Add(new SqlParameter("@P_SALE_DATE", SaleMaster.Rows[0]["SALE_DATE"].ToString()));
                lstInParam.Add(new SqlParameter("@P_BILL_NO", SaleMaster.Rows[0]["BILL_NO"].ToLong()));
                lstInParam.Add(new SqlParameter("@P_TAX",Convert.ToInt32( SaleMaster.Rows[0]["TAX"].ToString())));
                lstInParam.Add(new SqlParameter("@P_TOT_AMOUNT", SaleMaster.Rows[0]["TOTAL_AMOUNT"].ToDouble()));
                lstInParam.Add(new SqlParameter("@P_CREATED_BY", 1));
                lstInParam.Add(new SqlParameter("@P_SALE_DETAILS", SaleDetails));

                lstOutParam.Add(new SqlParameter("@P_SALE_ID", SqlDbType.BigInt));

                response = (new DataAccess()).DB.Insert_or_Update_Data("SALES_SP_SAVE_SALE", lstInParam.ToArray(), lstOutParam.ToArray());

                if (response != null)
                {
                    if (response.ReturnData != null)
                    {
                        if (response.ReturnData["@P_SALE_ID"].ToLong() > 0)
                        {
                            saleId = response.ReturnData["@P_SALE_ID"].ToLong();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.Status = ResponseStatus.EXCEPTION;
                response.Message = ex.Message;
            }

            return saleId;
        }

        public static long Modify_Sale(DataTable SaleMaster, DataTable SaleDetails)
        {
            var response = new AppResponse(ResponseStatus.FAILURE);
            long updatedRecords = 0;

            try
            {
                foreach (DataRow item in SaleDetails.Rows)
                {
                    List<SqlParameter> lstInParam = new List<SqlParameter>();
                    List<SqlParameter> lstOutParam = new List<SqlParameter>();

                    lstInParam.Add(new SqlParameter("@P_SALE_ID_PK", SaleMaster.Rows[0]["SALE_ID"].ToLong()));
                    lstInParam.Add(new SqlParameter("@P_SALE_DTS_ID", item["SALE_DTS_ID"].ToLong()));
                    lstInParam.Add(new SqlParameter("@P_CUST_NAME", SaleMaster.Rows[0]["CUSTOMER_NAME"].ToString()));
                    lstInParam.Add(new SqlParameter("@P_SALE_DATE", SaleMaster.Rows[0]["SALE_DATE"].ToString()));
                    lstInParam.Add(new SqlParameter("@P_BILL_NO", SaleMaster.Rows[0]["BILL_NO"].ToLong()));
                    lstInParam.Add(new SqlParameter("@P_TAX", Convert.ToInt32( SaleMaster.Rows[0]["TAX"].ToString())));
                    lstInParam.Add(new SqlParameter("@P_TOT_AMOUNT", SaleMaster.Rows[0]["TOTAL_AMOUNT"].ToDouble()));
                    lstInParam.Add(new SqlParameter("@P_ITEM_NO", item["ITEM_NO"].ToLong()));
                    lstInParam.Add(new SqlParameter("@P_ITEM_NAME", item["ITEM_NAME"].ToString()));
                    lstInParam.Add(new SqlParameter("@P_QTY", item["QTY"].ToDouble()));
                    lstInParam.Add(new SqlParameter("@P_PRICE", item["PRICE"].ToDouble()));
                    lstInParam.Add(new SqlParameter("@P_MODIFIED_BY", 1));

                    lstOutParam.Add(new SqlParameter("@P_SALE_ID", SqlDbType.BigInt));

                    response = (new DataAccess()).DB.Insert_or_Update_Data("SALES_SP_UPDATE_SALE", lstInParam.ToArray(), lstOutParam.ToArray());

                    if (response != null)
                    {
                        if (response.ReturnData != null)
                        {
                            if (response.ReturnData["@P_SALE_ID"].ToLong() > 0)
                            {
                                updatedRecords = response.ReturnData["@P_SALE_ID"].ToLong();
                            }
                            else
                            {
                                updatedRecords = 0;
                                return updatedRecords;
                            }
                        }
                    }

                    lstInParam.Clear();
                    lstOutParam.Clear();
                }
            }
            catch (Exception ex)
            {
                response.Status = ResponseStatus.EXCEPTION;
                response.Message = ex.Message;
            }

            return updatedRecords;
        }

        public static bool Cancel_Sale(long SaleId, long SaleDtsId)
        {
            var response = new AppResponse(ResponseStatus.FAILURE);

            try
            {
                List<SqlParameter> lstInParam = new List<SqlParameter>();
                List<SqlParameter> lstOutParam = new List<SqlParameter>();

                lstInParam.Add(new SqlParameter("@P_SALE_ID", SaleId));
                lstInParam.Add(new SqlParameter("@P_SALE_DTS_ID", SaleDtsId));
                lstInParam.Add(new SqlParameter("@P_DELETED_BY", 1));

                lstOutParam.Add(new SqlParameter("@P_RESULT", SqlDbType.BigInt));

                response = (new DataAccess()).DB.Insert_or_Update_Data("SALES_SP_CANCEL_SALE", lstInParam.ToArray(), lstOutParam.ToArray());

                if (response != null)
                {
                    if (response.ReturnData != null)
                    {
                        if (response.ReturnData["@P_RESULT"].ToLong() > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.Status = ResponseStatus.EXCEPTION;
                response.Message = ex.Message;
            }

            return false;
        }

        public static DataTable Get_Sales(long SaleId, string FromDate, string ToDate)
        {
            return (new DataAccess()).DB.GetData("SALES_SP_GET_SALES", new string[] { "@P_FROM_DATE", "@P_TO_DATE", "@P_SALE_ID" }, new string[] { FromDate,ToDate, SaleId.ToString() });
        }
    }
}
