
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
    public partial class AppConfigCoolingFanCompartmentGraphType : ObjectGraphType<AppConfigCoolingFanCompartment>
    {
        public AppConfigCoolingFanCompartmentGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfCoolingFans, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Fan1SpeedGi, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Fan2SpeedGi, type: typeof(ShortGraphType), nullable: False);
            
                Field<AppConfigCompartmentDetailGraphType, AppConfigCompartmentDetail>("AppConfigCompartmentDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<AppConfigCompartmentDetailGraphType>>(
                            "{ Name = EntityName "AppConfigCoolingFanCompartment"
  CorrespondingTable =
   Regular
     { Name = TableName "AppConfigCoolingFanCompartment"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "NumberOfCoolingFans"
                     IsNullable = false }; ForeignKey { Type = Short
                                                        Name = "Fan1LoadId"
                                                        IsNullable = false };
         Primitive { Type = Short
                     Name = "Fan1SpeedGi"
                     IsNullable = false }; ForeignKey { Type = Short
                                                        Name = "Fan2LoadId"
                                                        IsNullable = false };
         Primitive { Type = Short
                     Name = "Fan2SpeedGi"
                     IsNullable = false };
         Navigation { Type = TableName "AppConfigCompartmentDetail"
                      Name = "AppConfigCompartmentDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "NumberOfCoolingFans"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Fan1SpeedGi"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "Fan2SpeedGi"
      Type = Primitive Short
      IsNullable = false }]
  Relations =
   [OneToMany
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
                            });

                        return loader.LoadAsync(context.Source.AppConfigCompartmentDetails);
                    });
            
        }
    }
}
            