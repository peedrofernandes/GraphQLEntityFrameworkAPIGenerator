
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
    public partial class InductionIsofrequencyConfigurationsInductionIsofrequencyDetailGraphType : ObjectGraphType<InductionIsofrequencyConfigurationsInductionIsofrequencyDetail>
    {
        public InductionIsofrequencyConfigurationsInductionIsofrequencyDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionIsofreqConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.InductionIsofreqDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<InductionIsofrequencyConfigurationGraphType, InductionIsofrequencyConfiguration>("InductionIsofrequencyConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionIsofrequencyConfigurationGraphType>(
                            "{ Name =
   EntityName "InductionIsofrequencyConfigurationsInductionIsofrequencyDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "InductionIsofrequencyConfigurationsInductionIsofrequencyDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionIsofreqConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "InductionIsofreqDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "InductionIsofrequencyConfiguration"
                      Name = "InductionIsofreqConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "InductionIsofrequencyDetail"
                      Name = "InductionIsofreqDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "InductionIsofreqConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "InductionIsofreqDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "InductionIsofrequencyConfiguration"
        TargetTable =
         { Name = TableName "InductionIsofrequencyConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIsofreqConfigId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
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
             Navigation
               { Type =
                  TableName
                    "InductionIsofrequencyConfigurationsInductionIsofrequencyDetail"
                 Name =
                  "InductionIsofrequencyConfigurationsInductionIsofrequencyDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionIsofrequencyConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionIsofrequencyDetail"
        TargetTable =
         { Name = TableName "InductionIsofrequencyDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIsofreqDetailsId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfCoils"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "AdjacentCoil0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "AdjacentCoil1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "AdjacentCoil2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "AdjacentCoil3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "AdjacentCoil4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "AdjacentCoil5"
                                                          IsNullable = true };
             Navigation
               { Type =
                  TableName
                    "InductionIsofrequencyConfigurationsInductionIsofrequencyDetail"
                 Name =
                  "InductionIsofrequencyConfigurationsInductionIsofrequencyDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionIsofrequencyDetail"
        IsNullable = false
        KeyType = Guid }] }-InductionIsofrequencyConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionIsofrequencyConfigurations
                                    .Where(x => x.InductionIsofrequencyConfiguration != null && ids.Contains((Guid)x.InductionIsofrequencyConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionIsofrequencyConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionIsofrequencyConfiguration);
                });
            
			
                Field<InductionIsofrequencyDetailGraphType, InductionIsofrequencyDetail>("InductionIsofrequencyDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionIsofrequencyDetailGraphType>(
                            "{ Name =
   EntityName "InductionIsofrequencyConfigurationsInductionIsofrequencyDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "InductionIsofrequencyConfigurationsInductionIsofrequencyDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionIsofreqConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "InductionIsofreqDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "InductionIsofrequencyConfiguration"
                      Name = "InductionIsofreqConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "InductionIsofrequencyDetail"
                      Name = "InductionIsofreqDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "InductionIsofreqConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "InductionIsofreqDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "InductionIsofrequencyConfiguration"
        TargetTable =
         { Name = TableName "InductionIsofrequencyConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIsofreqConfigId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
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
             Navigation
               { Type =
                  TableName
                    "InductionIsofrequencyConfigurationsInductionIsofrequencyDetail"
                 Name =
                  "InductionIsofrequencyConfigurationsInductionIsofrequencyDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InductionIsofrequencyConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionIsofrequencyDetail"
        TargetTable =
         { Name = TableName "InductionIsofrequencyDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionIsofreqDetailsId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfCoils"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "AdjacentCoil0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "AdjacentCoil1"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "AdjacentCoil2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "AdjacentCoil3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "AdjacentCoil4"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "AdjacentCoil5"
                                                          IsNullable = true };
             Navigation
               { Type =
                  TableName
                    "InductionIsofrequencyConfigurationsInductionIsofrequencyDetail"
                 Name =
                  "InductionIsofrequencyConfigurationsInductionIsofrequencyDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionIsofrequencyDetail"
        IsNullable = false
        KeyType = Guid }] }-InductionIsofrequencyDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionIsofrequencyDetails
                                    .Where(x => x.InductionIsofrequencyDetail != null && ids.Contains((Guid)x.InductionIsofrequencyDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionIsofrequencyDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionIsofrequencyDetail);
                });
            
        }
    }
}
            