using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace TextTemplatingTest.EntityFrameworkCore
{
    public static class TextTemplatingTestDbContextModelCreatingExtensions
    {
        public static void ConfigureTextTemplatingTest(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(TextTemplatingTestConsts.DbTablePrefix + "YourEntities", TextTemplatingTestConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}