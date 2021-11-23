using FluentMigrator;

namespace OzonEdu.Merchandise.Migrator.Migrations
{        
    [Migration(3)]
    public class FillDictionaries:ForwardOnlyMigration  {
        public override void Up()
        {
            Execute.Sql(@"
                INSERT INTO set_types (id, name)
                VALUES 
                    (1, 'Welcome-pack'),
                    (2, 'Starter-pack'),
                    (3, 'Conference-listener-pack'),
                    (4, 'Conference-speaker-pack'),
                    (5, 'Veteran-pack')
                ON CONFLICT DO NOTHING
            ");
            
            Execute.Sql(@"
                INSERT INTO clothing_sizes (id, name)
                VALUES 
                    (1, 'XS'),
                    (2, 'S'),
                    (3, 'M'),
                    (4, 'L'),
                    (5, 'XL'),
                    (6, 'XXL')
                ON CONFLICT DO NOTHING
            ");
            
     
        }
    }
}