﻿namespace PngHub.Domain;
public class Image
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public byte[] Content { get; set; }
}
