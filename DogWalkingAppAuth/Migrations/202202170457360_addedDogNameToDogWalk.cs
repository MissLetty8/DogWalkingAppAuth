namespace DogWalkingAppAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDogNameToDogWalk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DogWalking", "DogName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DogWalking", "DogName");
        }
    }
}
