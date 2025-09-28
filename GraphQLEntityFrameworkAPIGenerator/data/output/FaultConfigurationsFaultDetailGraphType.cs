
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
    public partial class FaultConfigurationsFaultDetailGraphType : ObjectGraphType<FaultConfigurationsFaultDetail>
    {
        public FaultConfigurationsFaultDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FaultConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.FaultDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Priority, type: typeof(ByteGraphType), nullable: False);
            
                Field<FaultConfigurationGraphType, FaultConfiguration>("FaultConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, FaultConfigurationGraphType>(
                            "{ Name = EntityName "FaultConfigurationsFaultDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "FaultConfigurationsFaultDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "FaultConfigurationsId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "FaultDetailsId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Priority"
                                                        IsNullable = false };
         Navigation { Type = TableName "FaultConfiguration"
                      Name = "FaultConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "FaultDetail"
                      Name = "FaultDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "FaultConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "FaultDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "Priority"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FaultConfiguration"
        TargetTable =
         { Name = TableName "FaultConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FaultConfigurationsId"
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
             Navigation { Type = TableName "FaultConfigurationsFaultDetail"
                          Name = "FaultConfigurationsFaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "FaultConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "FaultDetail"
        TargetTable =
         { Name = TableName "FaultDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FaultDetailsId"
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
             ForeignKey { Type = Byte
                          Name = "FaultId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "SubCode"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "EngineeringCode"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "PauseCycle"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "DirectToFault"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "FaultParametersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "HasSubCycle"
                                                           IsNullable = false };
             ForeignKey { Type = Int
                          Name = "SubCycleNameId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Phase"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "DebounceParametersId"
                          IsNullable = true }; ForeignKey { Type = Byte
                                                            Name = "TargetId"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "MacroId"
                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "AllowClearWithoutRemovingFault"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ClearFaultAfterColdReset"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "CancelCycleOnly"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "EngineeringCodeMethod"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceParameters"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "FaultConfigurationsFaultDetail"
                          Name = "FaultConfigurationsFaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Macro"
                          Name = "Macro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Target"
                          Name = "Target"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "FaultDetail"
        IsNullable = false
        KeyType = Guid }] }-FaultConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.FaultConfigurations
                                    .Where(x => x.FaultConfiguration != null && ids.Contains((Guid)x.FaultConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.FaultConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.FaultConfiguration);
                });
            
			
                Field<FaultDetailGraphType, FaultDetail>("FaultDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, FaultDetailGraphType>(
                            "{ Name = EntityName "FaultConfigurationsFaultDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "FaultConfigurationsFaultDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "FaultConfigurationsId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "FaultDetailsId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Priority"
                                                        IsNullable = false };
         Navigation { Type = TableName "FaultConfiguration"
                      Name = "FaultConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "FaultDetail"
                      Name = "FaultDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "FaultConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "FaultDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "Priority"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FaultConfiguration"
        TargetTable =
         { Name = TableName "FaultConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FaultConfigurationsId"
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
             Navigation { Type = TableName "FaultConfigurationsFaultDetail"
                          Name = "FaultConfigurationsFaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "FaultConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "FaultDetail"
        TargetTable =
         { Name = TableName "FaultDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FaultDetailsId"
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
             ForeignKey { Type = Byte
                          Name = "FaultId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "SubCode"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "EngineeringCode"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "PauseCycle"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "DirectToFault"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "FaultParametersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "HasSubCycle"
                                                           IsNullable = false };
             ForeignKey { Type = Int
                          Name = "SubCycleNameId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Phase"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "DebounceParametersId"
                          IsNullable = true }; ForeignKey { Type = Byte
                                                            Name = "TargetId"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "MacroId"
                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "AllowClearWithoutRemovingFault"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ClearFaultAfterColdReset"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "CancelCycleOnly"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "EngineeringCodeMethod"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceParameters"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "FaultConfigurationsFaultDetail"
                          Name = "FaultConfigurationsFaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Macro"
                          Name = "Macro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Target"
                          Name = "Target"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "FaultDetail"
        IsNullable = false
        KeyType = Guid }] }-FaultDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.FaultDetails
                                    .Where(x => x.FaultDetail != null && ids.Contains((Guid)x.FaultDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.FaultDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.FaultDetail);
                });
            
        }
    }
}
            