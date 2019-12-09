using CodeGuide.Contract.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGuide.Business.Interfaces
{
    public interface IPostService
    {
        List<PostFilterResponseDTO> GetFilteredAppointments(PostFilterRequestDTO request);
    }
}
