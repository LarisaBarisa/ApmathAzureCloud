using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

public class ValuesController1 : ApiController
{    
    public string text="Test";
    public double[] Haha(/*double[,] x*/)
    {
        double[,] y = new double[3, 3]; 
        y[0, 0] = 2;
        y[0, 1] = -1;
        y[0, 2] = -1;
        y[1, 0] = 3;
        y[1, 1] = -2;
        y[1, 2] = -3;
        y[2, 0] = -1;
        y[2, 1] = 1;
        y[2, 2] = 2;

        double[] d= new double [3];
        double[,] z= new double [3,3];
//        alglib.evd.smatrixevd(x, Convert.ToInt32(Math.Sqrt(x.Length)),0,false,ref d,ref z);
        alglib.evd.smatrixevd(y, 3, 0, false, ref d, ref z);
        return d;
    }

    // GET api/<controller>
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<controller>/5
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<controller>
    public void Post([FromBody]string value)
    {
    }

    // PUT api/<controller>/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
}
