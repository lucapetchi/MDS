using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                CreatedBy = commentModel.AppUser.UserName,
                RestaurantId = commentModel.RestaurantId
            };
        }

        public static Comment ToCommentFromCreate(this CreateCommentDto commentDto, int restaurantId)
        {
            return new Comment
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
                RestaurantId = restaurantId
            };
        }

        public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto commentDto, int restaurantId)
        {
            return new Comment
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
                RestaurantId = restaurantId
            };
        }

    }
}