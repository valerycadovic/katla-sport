namespace KatlaSport.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Migration to dbo.catalogue_products to table product_price
    /// </summary>
    /// <seealso cref="System.Data.Entity.Migrations.DbMigration" />
    /// <seealso cref="System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata" />
    public partial class ChangePriceRequirementRulesFromOptionalToRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.catalogue_products", "product_description", c => c.String(maxLength: 3000));
            AlterColumn("dbo.catalogue_products", "product_price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }

        public override void Down()
        {
            AlterColumn("dbo.catalogue_products", "product_price", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.catalogue_products", "product_description", c => c.String(maxLength: 300));
        }
    }
}
