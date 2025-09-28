
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WP.Cooking.GESE.WebAPI.Models;
using GraphQL.DataLoader;
using WP.Cooking.GESE.WebAPI.Repositories; 


namespace WP.Cooking.GESE.WebAPI.GraphQL.Types
{
    public partial class UiledDriverTypeGraphType : ObjectGraphType<UiledDriverType>
    {
        public UiledDriverTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LedTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LedTypeDescription, type: typeof(StringGraphType), nullable: False);
            
                Field<UiledDriverParameterGraphType, UiledDriverParameter>("UiledDriverParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledDriverParameterGraphType>>(
                            "{ Name = EntityName "UiledDriverType"
  CorrespondingTable =
   Regular
     { Name = TableName "UiledDriverType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "LedTypeId"
                      IsNullable = false };
         Primitive { Type = String
                     Name = "LedTypeDescription"
                     IsNullable = false };
         Navigation { Type = TableName "UiledDriverParameter"
                      Name = "UiledDriverParameters"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "LedTypeId"
              Type = Id Byte
              IsNullable = false }; { Name = "LedTypeDescription"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UiledDriverParameter"
        TargetTable =
         { Name = TableName "UiledDriverParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiledDriverParametersId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "LedName"
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "LedTypeId"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Parameter1"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Parameter2"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Parameter3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Status"
                                                          IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
                                                           Name = "Timestamp"
                                                           IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Navigation { Type = TableName "UiledDriverType"
                          Name = "LedType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UiledConfigurationsUiledDriverParameter"
                 Name = "UiledConfigurationsUiledDriverParameters"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiledDriverParameter"
        KeyType = Guid }] }-UiledDriverParameter-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiledDriverParameters
                                    .Where(x => x.UiledDriverParameter != null && ids.Contains((Guid)x.UiledDriverParameter))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiledDriverParameter!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiledDriverParameters);
                    });
            
        }
    }
}
            