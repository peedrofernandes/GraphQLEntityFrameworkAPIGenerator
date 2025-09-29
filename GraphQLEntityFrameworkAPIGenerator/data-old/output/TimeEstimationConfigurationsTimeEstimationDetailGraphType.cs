
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
    public partial class TimeEstimationConfigurationsTimeEstimationDetailGraphType : ObjectGraphType<TimeEstimationConfigurationsTimeEstimationDetail>
    {
        public TimeEstimationConfigurationsTimeEstimationDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.TimeEstimationConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.TimeEstimationDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<TimeEstimationConfigurationGraphType, TimeEstimationConfiguration>("TimeEstimationConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, TimeEstimationConfigurationGraphType>(
                            "{ Name = EntityName "TimeEstimationConfigurationsTimeEstimationDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "TimeEstimationConfigurationsTimeEstimationDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "TimeEstimationConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "TimeEstimationDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "TimeEstimationConfiguration"
                      Name = "TimeEstimationConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "TimeEstimationDetail"
                      Name = "TimeEstimationDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "TimeEstimationConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "TimeEstimationDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "TimeEstimationConfiguration"
        TargetTable =
         { Name = TableName "TimeEstimationConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationConfigurationId"
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
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "TimeEstimationDetail"
        TargetTable =
         { Name = TableName "TimeEstimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifiersId"
                                                            IsNullable = true };
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
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationDetail"
        IsNullable = false
        KeyType = Guid }] }-TimeEstimationConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.TimeEstimationConfigurations
                                    .Where(x => x.TimeEstimationConfiguration != null && ids.Contains((Guid)x.TimeEstimationConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.TimeEstimationConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.TimeEstimationConfiguration);
                });
            
			
                Field<TimeEstimationDetailGraphType, TimeEstimationDetail>("TimeEstimationDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, TimeEstimationDetailGraphType>(
                            "{ Name = EntityName "TimeEstimationConfigurationsTimeEstimationDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "TimeEstimationConfigurationsTimeEstimationDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "TimeEstimationConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "TimeEstimationDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "TimeEstimationConfiguration"
                      Name = "TimeEstimationConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "TimeEstimationDetail"
                      Name = "TimeEstimationDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "TimeEstimationConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "TimeEstimationDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "TimeEstimationConfiguration"
        TargetTable =
         { Name = TableName "TimeEstimationConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationConfigurationId"
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
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "TimeEstimationDetail"
        TargetTable =
         { Name = TableName "TimeEstimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "TimeEstimationDetailId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "ModifiersLabel"
                         IsNullable = false }; ForeignKey { Type = Guid
                                                            Name = "ModifiersId"
                                                            IsNullable = true };
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
             Navigation { Type = TableName "Modifier"
                          Name = "Modifiers"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "TimeEstimationConfigurationsTimeEstimationDetail"
                 Name = "TimeEstimationConfigurationsTimeEstimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "TimeEstimationDetail"
        IsNullable = false
        KeyType = Guid }] }-TimeEstimationDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.TimeEstimationDetails
                                    .Where(x => x.TimeEstimationDetail != null && ids.Contains((Guid)x.TimeEstimationDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.TimeEstimationDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.TimeEstimationDetail);
                });
            
        }
    }
}
            