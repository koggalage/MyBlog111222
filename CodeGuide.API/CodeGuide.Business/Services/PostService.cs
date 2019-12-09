using CodeGuide.Contract.DTO;
using CodeGuide.EF.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGuide.Business.Services
{
    public class PostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public List<PostFilterResponseDTO> GetFilteredAppointments(PostFilterRequestDTO request)
        {
            var posts = _postRepository.All
                .Include(x => x.Category).ThenInclude(c => c.CategoryId)
                .Select(c => new PostFilterResponseDTO()
                {
                    EmployeeId = c.EmployeeId,
                    Title = c.Title,
                    CreatedDate = c.CreatedDate
                }).ToList();

            //if (request.DepartmentId.HasValue && request.DepartmentId.Value > 0)
            //{
            //    appointments = appointments.Where(x => x.departmentId == request.DepartmentId.Value).ToList();
            //}

            return posts;
        }
    }
}
