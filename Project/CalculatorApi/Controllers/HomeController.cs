using CalculatorApi.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Data.SqlClient;

namespace CalculatorApi.Controllers
{
    public class HomeController : ApiController
    {
        private readonly bool _isEntityFramework = false;
        private DataAccessLayer _dataAccessLayer;

        [Route("api/Home/Add")]
        [HttpGet]
        public int Add(int start, int amount)
        {
            int result = 0;
            //Call EntityFrmework or DataAccessLayer For Ado.net based on bool value
            if (_isEntityFramework)
            {
                using (var context = new CalculateEntities())
                {
                    object[] clientIdParameter = { new SqlParameter("@start", start),
                        new SqlParameter("@amount", amount)
                    };

                    result = context.Database.ExecuteSqlCommand("exec SP_Add @start, @amount", clientIdParameter);
                }
            }
            else
            {
                _dataAccessLayer = new DataAccessLayer();
                result = _dataAccessLayer.Add(start, amount);
            }
            return result;
        }

        [Route("api/Home/Subtract")]
        [HttpGet]
        public int Subtract(int start, int amount)
        {
            int result = 0;
            //Call EntityFrmework or DataAccessLayer For Ado.net based on bool value
            if (_isEntityFramework)
            {
                using (var context = new CalculateEntities())
                {
                    object[] clientIdParameter = { new SqlParameter("@start", start),
                        new SqlParameter("@amount", amount)
                    };

                    result = context.Database.ExecuteSqlCommand("exec SP_Subtract @start, @amount", clientIdParameter);
                }
            }
            else
            {
                _dataAccessLayer = new DataAccessLayer();
                result = _dataAccessLayer.Subtract(start, amount);
            }
            return result;
        }

        [Route("api/Home/Multiply")]
        [HttpGet]
        public int Multiply(int start, int by)
        {
            int result = 0;
            //Call EntityFrmework or DataAccessLayer For Ado.net based on bool value
            if (_isEntityFramework)
            {
                using (var context = new CalculateEntities())
                {
                    object[] clientIdParameter = { new SqlParameter("@start", start),
                        new SqlParameter("@amount", by)
                    };

                    result = context.Database.ExecuteSqlCommand("exec SP_Multiply @start, @amount", clientIdParameter);
                }
            }
            else
            {
                _dataAccessLayer = new DataAccessLayer();
                result = _dataAccessLayer.Multiply(start, by);
            }
            return result;
        }

        [Route("api/Home/Divide")]
        [HttpGet]
        public int Divide(int start, int by)
        {
            int result = 0;
            //Call EntityFrmework or DataAccessLayer For Ado.net based on bool value
            if (_isEntityFramework)
            {
                using (var context = new CalculateEntities())
                {
                    object[] clientIdParameter = { new SqlParameter("@start", start),
                        new SqlParameter("@amount", by)
                    };

                    result = context.Database.ExecuteSqlCommand("exec SP_Divide @start, @amount", clientIdParameter);
                }
            }
            else
            {
                _dataAccessLayer = new DataAccessLayer();
                result = _dataAccessLayer.Divide(start, by);
            }
            return result;
        }
    }
}
