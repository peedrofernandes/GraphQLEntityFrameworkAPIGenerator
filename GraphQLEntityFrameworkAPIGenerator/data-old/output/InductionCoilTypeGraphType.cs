
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
    public partial class InductionCoilTypeGraphType : ObjectGraphType<InductionCoilType>
    {
        public InductionCoilTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CoilTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CoilTypeDesc, type: typeof(StringGraphType), nullable: False);
            
                Field<InductionCoilChannelGraphType, InductionCoilChannel>("InductionCoilChannels")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionCoilChannelGraphType>>(
                            "{ Name = EntityName "InductionCoilType"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionCoilType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "CoilTypeId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "CoilTypeDesc"
                                                        IsNullable = false };
         Navigation { Type = TableName "InductionCoilChannel"
                      Name = "InductionCoilChannels"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "CoilTypeId"
              Type = Id Byte
              IsNullable = false }; { Name = "CoilTypeDesc"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "InductionCoilChannel"
        TargetTable =
         { Name = TableName "InductionCoilChannel"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilChannelId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "CoilType"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CoilPowerTableId"
                          IsNullable = true }; ForeignKey { Type = Byte
                                                            Name = "CoilNtcGiid"
                                                            IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "AssistedCookingNtcGiid"
                          IsNullable = true };
             Primitive { Type = Int
                         Name = "ResonanceCapacity"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ResonantCapacitorPresent"
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
               { Type = TableName "InductionCoilPowerTableConfiguration"
                 Name = "CoilPowerTable"
                 IsNullable = true
                 IsCollection = false };
             Navigation { Type = TableName "InductionCoilType"
                          Name = "CoilTypeNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InductionInverterChannelConfigurationCoilChannel0s"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InductionInverterChannelConfigurationCoilChannel1s"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilChannel"
        KeyType = Guid }] }-InductionCoilChannel-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCoilChannels
                                    .Where(x => x.InductionCoilChannel != null && ids.Contains((Guid)x.InductionCoilChannel))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionCoilChannel!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InductionCoilChannels);
                    });
            
        }
    }
}
            