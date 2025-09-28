
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
    public partial class CycleOptionsConfigurationGraphType : ObjectGraphType<CycleOptionsConfiguration>
    {
        public CycleOptionsConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleOptionsConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<CycleMappingCycleOptionsConfigurationGraphType, CycleMappingCycleOptionsConfiguration>("CycleMappingCycleOptionsConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingCycleOptionsConfigurationGraphType>>(
                            "{ Name = EntityName "CycleOptionsConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleOptionsConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleOptionsConfigurationsId"
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
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true };
         Navigation { Type = TableName "CycleMappingCycleOptionsConfiguration"
                      Name = "CycleMappingCycleOptionsConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
             Name = "CycleOptionsConfigurationsCycleOptionsDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "CycleOptionsConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "CycleMappingCycleOptionsConfiguration"
        TargetTable =
         { Name = TableName "CycleMappingCycleOptionsConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleOptionsConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "CycleName"
                                                            IsNullable = true };
             Primitive { Type = String
                         Name = "HmiCycleName"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "ConnectivityCycleEnumeration0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Compartment0"
                                                          IsNullable = false };
             Primitive { Type = Long
                         Name = "ConnectivityCycleKey0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "UriTreeId"
                                                           IsNullable = true };
             Navigation { Type = TableName "CycleMapping"
                          Name = "CycleMapping"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleOptionsConfiguration"
                          Name = "CycleOptionsConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingUri"
                          Name = "UriTree"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "CycleMappingCycleOptionsConfiguration"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "CycleOptionsConfigurationsCycleOptionsDetail"
        TargetTable =
         { Name = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleOptionsConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleOptionsDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "CycleOptionsConfiguration"
                          Name = "CycleOptionsConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleOptionsDetail"
                          Name = "CycleOptionsDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CycleOptionsConfigurationsCycleOptionsDetail"
        KeyType = Guid }] }-CycleMappingCycleOptionsConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleMappingCycleOptionsConfigurations
                                    .Where(x => x.CycleMappingCycleOptionsConfiguration != null && ids.Contains((Guid)x.CycleMappingCycleOptionsConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleMappingCycleOptionsConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleMappingCycleOptionsConfigurations);
                    });
            
			
                Field<CycleOptionsConfigurationsCycleOptionsDetailGraphType, CycleOptionsConfigurationsCycleOptionsDetail>("CycleOptionsConfigurationsCycleOptionsDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsConfigurationsCycleOptionsDetailGraphType>>(
                            "{ Name = EntityName "CycleOptionsConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleOptionsConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleOptionsConfigurationsId"
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
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true };
         Navigation { Type = TableName "CycleMappingCycleOptionsConfiguration"
                      Name = "CycleMappingCycleOptionsConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
             Name = "CycleOptionsConfigurationsCycleOptionsDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "CycleOptionsConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "CycleMappingCycleOptionsConfiguration"
        TargetTable =
         { Name = TableName "CycleMappingCycleOptionsConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleOptionsConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "CycleName"
                                                            IsNullable = true };
             Primitive { Type = String
                         Name = "HmiCycleName"
                         IsNullable = true };
             Primitive { Type = Int
                         Name = "ConnectivityCycleEnumeration0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Compartment0"
                                                          IsNullable = false };
             Primitive { Type = Long
                         Name = "ConnectivityCycleKey0"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels"
                         IsNullable = true }; ForeignKey { Type = Guid
                                                           Name = "UriTreeId"
                                                           IsNullable = true };
             Navigation { Type = TableName "CycleMapping"
                          Name = "CycleMapping"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleOptionsConfiguration"
                          Name = "CycleOptionsConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingUri"
                          Name = "UriTree"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "CycleMappingCycleOptionsConfiguration"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "CycleOptionsConfigurationsCycleOptionsDetail"
        TargetTable =
         { Name = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleOptionsConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CycleOptionsDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "CycleOptionsConfiguration"
                          Name = "CycleOptionsConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleOptionsDetail"
                          Name = "CycleOptionsDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CycleOptionsConfigurationsCycleOptionsDetail"
        KeyType = Guid }] }-CycleOptionsConfigurationsCycleOptionsDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleOptionsConfigurationsCycleOptionsDetails
                                    .Where(x => x.CycleOptionsConfigurationsCycleOptionsDetail != null && ids.Contains((Guid)x.CycleOptionsConfigurationsCycleOptionsDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleOptionsConfigurationsCycleOptionsDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleOptionsConfigurationsCycleOptionsDetails);
                    });
            
        }
    }
}
            