﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaVilla.Application.Exceptions
{
    public class UnprocessableEntityException : Exception
    {
        public UnprocessableEntityException()
        {

        }

        public UnprocessableEntityException(string message)
            : base(message)
        {

        }
    }
}
