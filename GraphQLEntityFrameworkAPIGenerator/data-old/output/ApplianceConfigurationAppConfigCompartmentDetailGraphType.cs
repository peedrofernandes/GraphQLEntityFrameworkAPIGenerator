
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
    public partial class ApplianceConfigurationAppConfigCompartmentDetailGraphType : ObjectGraphType<ApplianceConfigurationAppConfigCompartmentDetail>
    {
        public ApplianceConfigurationAppConfigCompartmentDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ApplianceConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.AppConfigCompartmentDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<AppConfigCompartmentDetailGraphType, AppConfigCompartmentDetail>("AppConfigCompartmentDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, AppConfigCompartmentDetailGraphType>(
                            "{ Name = EntityName "ApplianceConfigurationAppConfigCompartmentDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "ApplianceConfigurationAppConfigCompartmentDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ApplianceConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "AppConfigCompartmentDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "AppConfigCompartmentDetail"
                      Name = "AppConfigCompartmentDetails"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "ApplianceConfiguration"
                      Name = "ApplianceConfiguration"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "ApplianceConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "AppConfigCompartmentDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AppConfigCompartmentDetail"
        TargetTable =
         { Name = TableName "AppConfigCompartmentDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AppConfigCompartmentDetailsId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Name"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "CompartmentType"
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
                         Name = "Version"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "OvenMwcompartmentId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "OvenCoolingFanCompId"
                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "HallEffectSensorPresent"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "BackupRestore"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName "ApplianceConfigurationAppConfigCompartmentDetail"
                 Name = "ApplianceConfigurationAppConfigCompartmentDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "AppConfigCoolingFanCompartment"
                          Name = "OvenCoolingFanComp"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "AppConfigOvenMwcompartment"
                          Name = "OvenMwcompartment"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "AppConfigCompartmentDetail"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "ApplianceConfiguration"
        TargetTable =
         { Name = TableName "ApplianceConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ApplianceConfigurationId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "MinimumOnTime"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "MinimumOffTime"
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
                  TableName "ApplianceConfigurationAppConfigCompartmentDetail"
                 Name = "ApplianceConfigurationAppConfigCompartmentDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ApplianceConfiguration"
        IsNullable = false
        KeyType = Guid }] }-AppConfigCompartmentDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.AppConfigCompartmentDetails
                                    .Where(x => x.AppConfigCompartmentDetail != null && ids.Contains((Guid)x.AppConfigCompartmentDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.AppConfigCompartmentDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.AppConfigCompartmentDetail);
                });
            
			
                Field<ApplianceConfigurationGraphType, ApplianceConfiguration>("ApplianceConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, ApplianceConfigurationGraphType>(
                            "{ Name = EntityName "ApplianceConfigurationAppConfigCompartmentDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "ApplianceConfigurationAppConfigCompartmentDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ApplianceConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "AppConfigCompartmentDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "AppConfigCompartmentDetail"
                      Name = "AppConfigCompartmentDetails"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "ApplianceConfiguration"
                      Name = "ApplianceConfiguration"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "ApplianceConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "AppConfigCompartmentDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "AppConfigCompartmentDetail"
        TargetTable =
         { Name = TableName "AppConfigCompartmentDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AppConfigCompartmentDetailsId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Name"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "CompartmentType"
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
                         Name = "Version"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "OvenMwcompartmentId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "OvenCoolingFanCompId"
                          IsNullable = true };
             Primitive { Type = Bool
                         Name = "HallEffectSensorPresent"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "BackupRestore"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName "ApplianceConfigurationAppConfigCompartmentDetail"
                 Name = "ApplianceConfigurationAppConfigCompartmentDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "AppConfigCoolingFanCompartment"
                          Name = "OvenCoolingFanComp"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "AppConfigOvenMwcompartment"
                          Name = "OvenMwcompartment"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "AppConfigCompartmentDetail"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "ApplianceConfiguration"
        TargetTable =
         { Name = TableName "ApplianceConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ApplianceConfigurationId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "MinimumOnTime"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "MinimumOffTime"
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
                  TableName "ApplianceConfigurationAppConfigCompartmentDetail"
                 Name = "ApplianceConfigurationAppConfigCompartmentDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ApplianceConfiguration"
        IsNullable = false
        KeyType = Guid }] }-ApplianceConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.ApplianceConfigurations
                                    .Where(x => x.ApplianceConfiguration != null && ids.Contains((Guid)x.ApplianceConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.ApplianceConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.ApplianceConfiguration);
                });
            
        }
    }
}
            