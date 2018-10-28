using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ai.Olami.Example {

    /*
     * 返回字段（根据JSON 推理出）
     * 时间：20181028
     * by syc
     * 
     */
  public   class Response {

        public Data data;
         
        public string status;
    }

    public class Data{
        public Status asr;
        public string seg;
        public Description[] nli;
        
    }

    public class Status{
        public string result;
        public string requestId;
       public  int   speech_status;
        public bool final;
        public int status;
    }

    public class Description {
        public MSG desc_obj;
        public string type;
    }

    public class MSG {
        public string result;
        public int status;
    }

}

