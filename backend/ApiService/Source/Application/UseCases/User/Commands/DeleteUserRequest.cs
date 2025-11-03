using CSharpFunctionalExtensions;
using FluentValidation.Results;
using MediatR;
using RoomAggregate = Epam.ItMarathon.ApiService.Domain.Aggregate.Room.Room;

namespace Epam.ItMarathon.ApiService.Application.UseCases.User.Queries
{
    /// <summary>
    /// Represents a request to delete a user from a room.
    /// </summary>
    public record DeleteUserRequest
        : IRequest<Result<RoomAggregate, ValidationResult>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUserRequest"/> record.
        /// </summary>
        /// <param name="UserCode">The code of the user to delete.</param>
        /// <param name="UserId">The ID of the user to delete.</param>
        public DeleteUserRequest(string UserCode, ulong? UserId)
        {
            this.UserCode = UserCode;
            this.UserId = UserId;
        }

        /// <summary>
        /// Gets the code of the user to delete.
        /// </summary>
        public string UserCode { get; init; }

        /// <summary>
        /// Gets the ID of the user to delete.
        /// </summary>
        public ulong? UserId { get; init; }
    }
}