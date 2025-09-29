
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
    public partial class UianimationFrameConfigurationsUianimationFrameDetailGraphType : ObjectGraphType<UianimationFrameConfigurationsUianimationFrameDetail>
    {
        public UianimationFrameConfigurationsUianimationFrameDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UianimationFrameConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UianimationFrameDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UianimationFrameConfigurationGraphType, UianimationFrameConfiguration>("UianimationFrameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationFrameConfigurationGraphType>(
                            "{ Name = EntityName "UianimationFrameConfigurationsUianimationFrameDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UianimationFrameConfigurationsUianimationFrameDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UianimationFrameConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UianimationFrameDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UianimationFrameConfiguration"
                      Name = "UianimationFrameConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UianimationFrameDetail"
                      Name = "UianimationFrameDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UianimationFrameConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UianimationFrameDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UianimationFrameConfiguration"
        TargetTable =
         { Name = TableName "UianimationFrameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationFrameConfigurationsId"
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
             Primitive { Type = Byte
                         Name = "NumOfFrames"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "UianimationFrameConfigurationsUianimationFrameDetail"
                 Name = "UianimationFrameConfigurationsUianimationFrameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UianimationFrameConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationFrameDetail"
        TargetTable =
         { Name = TableName "UianimationFrameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationFrameDetailsId"
                          IsNullable = false }; Primitive { Type = Long
                                                            Name = "Pattern"
                                                            IsNullable = false };
             Primitive { Type = Short
                         Name = "TimeOn"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FrameIntensity"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "UianimationFrameConfigurationsUianimationFrameDetail"
                 Name = "UianimationFrameConfigurationsUianimationFrameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UianimationFrameDetail"
        IsNullable = false
        KeyType = Guid }] }-UianimationFrameConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UianimationFrameConfigurations
                                    .Where(x => x.UianimationFrameConfiguration != null && ids.Contains((Guid)x.UianimationFrameConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UianimationFrameConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UianimationFrameConfiguration);
                });
            
			
                Field<UianimationFrameDetailGraphType, UianimationFrameDetail>("UianimationFrameDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationFrameDetailGraphType>(
                            "{ Name = EntityName "UianimationFrameConfigurationsUianimationFrameDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UianimationFrameConfigurationsUianimationFrameDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UianimationFrameConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UianimationFrameDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "UianimationFrameConfiguration"
                      Name = "UianimationFrameConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UianimationFrameDetail"
                      Name = "UianimationFrameDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UianimationFrameConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UianimationFrameDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UianimationFrameConfiguration"
        TargetTable =
         { Name = TableName "UianimationFrameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationFrameConfigurationsId"
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
             Primitive { Type = Byte
                         Name = "NumOfFrames"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "UianimationFrameConfigurationsUianimationFrameDetail"
                 Name = "UianimationFrameConfigurationsUianimationFrameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UianimationFrameConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationFrameDetail"
        TargetTable =
         { Name = TableName "UianimationFrameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationFrameDetailsId"
                          IsNullable = false }; Primitive { Type = Long
                                                            Name = "Pattern"
                                                            IsNullable = false };
             Primitive { Type = Short
                         Name = "TimeOn"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FrameIntensity"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "UianimationFrameConfigurationsUianimationFrameDetail"
                 Name = "UianimationFrameConfigurationsUianimationFrameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UianimationFrameDetail"
        IsNullable = false
        KeyType = Guid }] }-UianimationFrameDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UianimationFrameDetails
                                    .Where(x => x.UianimationFrameDetail != null && ids.Contains((Guid)x.UianimationFrameDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UianimationFrameDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UianimationFrameDetail);
                });
            
        }
    }
}
            