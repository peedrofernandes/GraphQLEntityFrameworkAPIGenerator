
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
    public partial class SrexpansionDetailGraphType : ObjectGraphType<SrexpansionDetail>
    {
        public SrexpansionDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SrexpansionDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DuplicateOverTempCheckParams, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DuplicatePlausibilityCheckParams, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DuplicatePcbCheckParams, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DuplicatePinShortCheckParams, type: typeof(BoolGraphType), nullable: False);
            
                Field<SrexpansionConfigurationsSrexpansionDetailGraphType, SrexpansionConfigurationsSrexpansionDetail>("SrexpansionConfigurationsSrexpansionDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SrexpansionConfigurationsSrexpansionDetailGraphType>>(
                            "{ Name = EntityName "SrexpansionDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "SrexpansionDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SrexpansionDetailsId"
                      IsNullable = false };
         Primitive { Type = Bool
                     Name = "DuplicateOverTempCheckParams"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "DuplicatePlausibilityCheckParams"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "DuplicatePcbCheckParams"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "DuplicatePinShortCheckParams"
                     IsNullable = false };
         Navigation
           { Type = TableName "SrexpansionConfigurationsSrexpansionDetail"
             Name = "SrexpansionConfigurationsSrexpansionDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "SrexpansionDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "DuplicateOverTempCheckParams"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "DuplicatePlausibilityCheckParams"
      Type = Primitive Bool
      IsNullable = false }; { Name = "DuplicatePcbCheckParams"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "DuplicatePinShortCheckParams"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "SrexpansionConfigurationsSrexpansionDetail"
        TargetTable =
         { Name = TableName "SrexpansionConfigurationsSrexpansionDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SrexpansionConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "SrexpansionDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "SrexpansionConfiguration"
                          Name = "SrexpansionConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "SrexpansionDetail"
                          Name = "SrexpansionDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "SrexpansionConfigurationsSrexpansionDetail"
        KeyType = Guid }] }-SrexpansionConfigurationsSrexpansionDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.SrexpansionConfigurationsSrexpansionDetails
                                    .Where(x => x.SrexpansionConfigurationsSrexpansionDetail != null && ids.Contains((Guid)x.SrexpansionConfigurationsSrexpansionDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.SrexpansionConfigurationsSrexpansionDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.SrexpansionConfigurationsSrexpansionDetails);
                    });
            
        }
    }
}
            