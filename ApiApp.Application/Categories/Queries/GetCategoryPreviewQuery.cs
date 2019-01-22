using System.Collections.Generic;
using MediatR;
using ApiApp.Application.Categories.Models;

namespace ApiApp.Application.Categories.Queries
{
    public class GetCategoryPreviewQuery : IRequest<List<CategoryPreviewDto>>
    {
        public int CategoryId { get; set; }
    }
}
