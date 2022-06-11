﻿using PizzaVilla.Application.UseCases.DTO;
using PizzaVilla.Application.UseCases.DTO.Searches;
using PizzaVilla.Application.UseCases.Queries.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaVilla.Application.UseCases.Queries.AuditLog
{
    public interface IGetAuditLogQuery : IQuery<BasePagedDateSearch, PagedResponse<AuditLogDto>>
    {
    }
}
