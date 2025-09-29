
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
    public partial class LoadGroupGraphType : ObjectGraphType<LoadGroup>
    {
        public LoadGroupGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LoadGroupId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadGroupDsc, type: typeof(StringGraphType), nullable: False);
            
                Field<LoadGraphType, Load>("Loads")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadGraphType>(
                            "{ Name = EntityName "LoadGroup"
  CorrespondingTable =
   Regular
     { Name = TableName "LoadGroup"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "LoadGroupId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "LoadGroupDsc"
                                                        IsNullable = false };
         Navigation { Type = TableName "Load"
                      Name = "Loads"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "LoadGroupId"
              Type = Id Byte
              IsNullable = false }; { Name = "LoadGroupDsc"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [ManyToMany
      { Name = RelationName "Load"
        TargetTable =
         { Name = TableName "Load"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LoadDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadTypeId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "LoadsControl"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "CrossLoadDetail"
                          Name = "CrossLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadType"
                          Name = "LoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId9Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadGroup"
                          Name = "LoadGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Load"
        KeyType = Byte }] }-Load-loader",
                            async ids => 
                            {
                                var data = await dbContext.Loads
                                    .Where(x => x.Load.Any(c => ids.Contains(c.LoadId)))
                                    .Select(x => new
                                    {
                                        Key = x,
                                        Values = x.Load,
                                    })
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => x.Values.Select(v => new { Key = v.LoadId, Value = x.Key }))
                                    .ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Loads);
                    });
            
        }
    }
}
            