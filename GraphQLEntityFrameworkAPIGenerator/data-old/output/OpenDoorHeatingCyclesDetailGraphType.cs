
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
    public partial class OpenDoorHeatingCyclesDetailGraphType : ObjectGraphType<OpenDoorHeatingCyclesDetail>
    {
        public OpenDoorHeatingCyclesDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.OpenDoorHeatingCyclesDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CycleName, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(StringGraphType), nullable: False);
			Field(t => t.ConvFanFlag, type: typeof(BoolGraphType), nullable: False);
            
                Field<OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetailGraphType, OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail>("OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetailGraphType>>(
                            "{ Name = EntityName "OpenDoorHeatingCyclesDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "OpenDoorHeatingCyclesDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "OpenDoorHeatingCyclesDetailsId"
                      IsNullable = false }; Primitive { Type = Int
                                                        Name = "CycleName"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Compartment"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "ConvFanFlag"
                                                       IsNullable = false };
         Navigation
           { Type =
              TableName
                "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail"
             Name =
              "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "OpenDoorHeatingCyclesDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "CycleName"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "Compartment"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "ConvFanFlag"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail"
        TargetTable =
         { Name =
            TableName
              "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "OpenDoorHeatingCyclesConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "OpenDoorHeatingCyclesDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "OpenDoorHeatingCyclesConfiguration"
                          Name = "OpenDoorHeatingCyclesConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "OpenDoorHeatingCyclesDetail"
                          Name = "OpenDoorHeatingCyclesDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail"
        KeyType = Guid }] }-OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails
                                    .Where(x => x.OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail != null && ids.Contains((Guid)x.OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails);
                    });
            
        }
    }
}
            