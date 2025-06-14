using Microsoft.EntityFrameworkCore;
using angularCinema.Data;

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));