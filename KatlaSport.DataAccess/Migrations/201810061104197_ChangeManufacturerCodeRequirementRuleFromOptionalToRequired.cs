namespace KatlaSport.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Migration to dbo.catalogue_products to table product_manufacturer_code
    /// </summary>
    /// <seealso cref="System.Data.Entity.Migrations.DbMigration" />
    /// <seealso cref="System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata" />
    public partial class ChangeManufacturerCodeRequirementRuleFromOptionalToRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.catalogue_products", "product_manufacturer_code", c => c.String(nullable: false, maxLength: 10));
        }

        public override void Down()
        {
            AlterColumn("dbo.catalogue_products", "product_manufacturer_code", c => c.String(maxLength: 10));
        }
    }
}
