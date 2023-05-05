using ParksLookupApi.Models;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ApiExplorer;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// builder.Services.AddControllersWithViews()
//     .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


builder.Services.AddDbContext<ParksLookupApiContext>(
                  dbContextOptions => dbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:DefaultConnection"], 
                      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                  )
                );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
  c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()) ///===============================
);
builder.Services.AddApiVersioning(opt =>
                                    {
                                        opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1,0);
                                        opt.AssumeDefaultVersionWhenUnspecified = true;
                                        opt.ReportApiVersions = true;
                                        opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                                                        new HeaderApiVersionReader("x-api-version"),
                                                                                        new MediaTypeApiVersionReader("x-api-version"));
                                    });
builder.Services.AddVersionedApiExplorer(setup =>
{
    setup.GroupNameFormat = "'v'VVV";
    setup.SubstituteApiVersionInUrl = true;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
var app = builder.Build();

var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI(options =>
	{
		foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
		{
			options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
				description.GroupName.ToUpperInvariant());
		}
	});
}
else
{
  app.UseHttpsRedirection();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();