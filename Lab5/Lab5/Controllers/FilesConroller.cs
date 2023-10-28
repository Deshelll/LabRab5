using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Test2;

[Route("api/files")]
[ApiController]
public class FilesController : ControllerBase
{
    private readonly AppDbContext _context;

    public FilesController(AppDbContext context)
    {
        _context = context;
    }
