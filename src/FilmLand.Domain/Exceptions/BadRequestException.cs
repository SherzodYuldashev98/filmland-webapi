﻿using System.Net;

namespace FilmLand.Domain.Exceptions;

public class BadRequestException : ClientException
{
    public override HttpStatusCode StatusCode { get; } = HttpStatusCode.BadRequest;
    public override string TitleMessage { get; protected set; } = String.Empty;
}
