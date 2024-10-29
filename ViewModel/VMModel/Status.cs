﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace ViewModel.VMModel
{
   public  class Status
    {
        private HttpStatusCode _code;
        private string _message;
        private bool _isErrorInService;
        private bool _success;
        private bool _exist;


        public HttpStatusCode code
        {
            get { return _code; }
            set { _code = value; }
        }
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        public bool isErrorInService
        {
            get { return _isErrorInService; }
            set { _isErrorInService = value; }
        }

        public bool success
        {
            get { return _success; }
            set { _success = value; }
        }
        public bool exist
        {
            get { return _exist; }
            set { _exist = value; }
        }
    }
}