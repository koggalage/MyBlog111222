using CodeGuide.Contract.DTO;
using CodeGuide.EF.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGuide.Mapper
{
    public static class DomainDTOMapper
    {
        public static List<PostFilterRequestDTO> ToPostDTOs(List<Post> posts)
        {
            return AutoMapper.Mapper.Map<List<Post>, List<PostFilterRequestDTO>>(posts);
        }

        public static PostFilterRequestDTO ToPostDTO(Post post)
        {
            return AutoMapper.Mapper.Map<Post, PostFilterRequestDTO>(post);
        }

        public static Post ToPostDomain(PostFilterRequestDTO postDTO)
        {
            return AutoMapper.Mapper.Map<PostFilterRequestDTO, Post>(postDTO);
        }
    }
}
