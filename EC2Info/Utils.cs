using Amazon.EC2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC2Info
{
    class Utils
    {
        public static string GetEC2PropFromString(string input, Amazon.EC2.Model.Instance i)
        {
            string result = "";

            input = input.Replace(" ", string.Empty);

            string[] inputArr = input.Split('=');
            if (inputArr.Length > 1)
            {
                if (inputArr[0].ToLower() == "tag")
                {
                    result = GetEC2Tag(i.Tags, inputArr[1]);
                }
            }
            else
            {                

                switch (input.ToLower())
                {
                    case "architecture":
                        result = i.Architecture;
                        break;
                    case "blockdevicemappings":
                        result = GetBlockDeviceMappings(i.BlockDeviceMappings, "all");
                        break;
                    case "blockdevicenames":
                        result = GetBlockDeviceMappings(i.BlockDeviceMappings, "name");
                        break;
                    case "blockdevicevolumeids":
                        result = GetBlockDeviceMappings(i.BlockDeviceMappings, "volumeid");
                        break;
                    case "ebsoptimized":
                        if (i.EbsOptimized != null) { result = i.EbsOptimized.ToString(); }
                        break;
                    case "enasupport":
                        if (i.EnaSupport != null) { result = i.EnaSupport.ToString(); }
                        break;
                    case "hypervisor":
                        result = i.Hypervisor;
                        break;
                    case "iaminstanceprofile":
                        if (i.IamInstanceProfile != null) { result = i.IamInstanceProfile.Id; }
                        break;                    
                    case "instanceid":
                        result = i.InstanceId;
                        break;
                    case "instancetype":
                        result = i.InstanceType;
                        break;
                    case "kernelid":
                        result = i.KernelId;
                        break;
                    case "keyname":
                        result = i.KeyName;
                        break;
                    case "launchtime":
                        result = i.LaunchTime.ToString("yyyy-MM-dd HH:mm:ss");
                        break;
                    case "monitoring":
                        if (i.Monitoring != null) { result = i.Monitoring.State.Value; }
                        break;
                    case "networkinterfaces":
                        result = GetNetworkInterfaces(i.NetworkInterfaces, "all");
                        break;
                    case "networkinterfaceids":
                        result = GetNetworkInterfaces(i.NetworkInterfaces, "networkinterfaceIds");
                        break;
                    case "networkinterfaceprivateips":
                        result = GetNetworkInterfaces(i.NetworkInterfaces, "networkinterfaceprivateips");
                        break;
                    case "placement":
                        result = "";
                        break;
                    case "platform":
                        if (i.Platform != null) { result = i.Platform.Value; }
                        break;
                    case "privatednsname":
                        result = i.PrivateDnsName;
                        break;
                    case "privateipaddress":
                        result = i.PrivateIpAddress;
                        break;
                    case "publicdnsname":
                        result = i.PublicDnsName;
                        break; 
                    case "publicipaddress":
                        result = i.PublicIpAddress;
                        break;
                    case "rootdevicename":
                        result = i.RootDeviceName;
                        break;
                    case "rootdevicetype":
                        if (i.RootDeviceType != null) { result = i.RootDeviceType.Value; }
                        break;
                    case "securitygroups":
                        result = GetEC2SecurityGroups(i.SecurityGroups);
                        break;
                    case "snapshots":
                        result = GetSnapshots(i.BlockDeviceMappings, "all");
                        break;
                    case "stackcreationtime":
                        string stackName = GetEC2Tag(i.Tags, Properties.Settings.Default.StackNameTag);
                        result = GetStackCreationTime(stackName);
                        break;
                    case "stackname":
                        result = stackName = GetEC2Tag(i.Tags, Properties.Settings.Default.StackNameTag);                        
                        break;
                    case "stackid":
                        result = stackName = GetEC2Tag(i.Tags, Properties.Settings.Default.StackIdTag);
                        break;
                    case "stacklogicalid":
                        result = stackName = GetEC2Tag(i.Tags, Properties.Settings.Default.StackLogicalIdTag);
                        break;
                    case "subnetid":
                        result = i.SubnetId;
                        break;
                    case "state":
                        if (i.State != null) { result = i.State.Name; }
                        break;
                    case "imageid":
                        result = i.ImageId;
                        break;
                    case "vpcid":
                        result = i.VpcId;
                        break;
                    case "name":
                        if (i.Tags != null) { result = GetEC2Tag(i.Tags, "name"); }
                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        public static string GetSnapshots(List<InstanceBlockDeviceMapping> deviceMappings, string returnType)
        {
            string result = "";
            if (deviceMappings != null)
            {
                foreach (InstanceBlockDeviceMapping item in deviceMappings)
                {
                    List<Snapshot> snaps = App.Snapshots.FindAll(x => x.VolumeId != null && String.Compare(x.VolumeId, item.Ebs.VolumeId) == 0);
                    foreach (var snap in snaps)
                    {

                        switch (returnType.ToLower())
                        {
                            case "snapshotid":
                                result += snap.SnapshotId +  LineEnding();                                
                                break;
                            case "volumeid":
                                result += item.Ebs.VolumeId +  LineEnding();
                                break;
                            default:
                                result += "VolumeId: " + snap.VolumeId + " SnapshotId: " + snap.SnapshotId + LineEnding();
                                break;
                        }

                    }
                }
                if (result.Length > 0)
                {
                    result = result.Remove(result.Length - 2, 2);
                }
            }
            return result;
        }

        public static string GetStackCreationTime(string stackName)
        {
            string result = "";

            var a = App.Stacks.Find(x => x != null && x.StackName == stackName);
            if (a != null)
            {
                result = a.CreationTime.ToString(Properties.Settings.Default.DateTimeFormat);
            }

            return result;
        }

        public static string GetBlockDeviceMappings(List<InstanceBlockDeviceMapping> deviceMappings, string returnType)
        {
            string result = "";
            if (deviceMappings != null)
            {
                foreach (InstanceBlockDeviceMapping item in deviceMappings)
                {
                    switch (returnType.ToLower())
                    {
                        case "name":
                            result += item.DeviceName + LineEnding();                          
                            break;
                        case "volumeid":
                            result += item.Ebs.VolumeId + LineEnding();                            
                            break;
                        default:
                            result += "Name: " + item.DeviceName + " VolumeId: " + item.Ebs.VolumeId + LineEnding();                     
                            break;
                    }                    
                }
                if (result.Length > 0)
                {
                    result = result.Remove(result.Length - 2, 2);
                }
            }
            return result;
        }

        public static string GetEC2Tag(List<Amazon.EC2.Model.Tag> tags, string search)
        {
            string result = "";
            if (tags != null)
            {
                var a = tags.Find(n => n != null && n.Key.ToLower() == search.ToLower());
                if (a != null)
                {
                    result = a.Value;
                }
            }

            return result;
        }

        public static string GetEC2SecurityGroups(List<Amazon.EC2.Model.GroupIdentifier> groups)
        {
            string result = "";
            if (groups != null)
            {
                foreach (var sg in groups)
                {
                    result += sg.GroupId + LineEnding();
                }
            }
            if (result.Length > 0)
            {
                result = result.Remove(result.Length - 1);              
            }
            
            return result;
            
        }

        public static string GetNetworkInterfaces(List<InstanceNetworkInterface> networkInterfaces, string returnType)
        {
            string result = "";
            if (networkInterfaces != null)
            {
                foreach (InstanceNetworkInterface item in networkInterfaces)
                {
                    switch (returnType.ToLower())
                    {
                        case "networkinterfaceids":
                            result += item.NetworkInterfaceId + LineEnding();
                            break;
                        case "networkinterfaceprivateips":
                            result += item.PrivateIpAddress + LineEnding();
                            break;
                        default:
                            result += "Id: " + item.NetworkInterfaceId + " PrivateIP: " + item.PrivateIpAddress + LineEnding();
                            break;
                    }  
                }
                if (result.Length > 0)
                {
                    result = result.Remove(result.Length - 2, 2);
                }
            }
            
            return result;

        }


        static string LineEnding()
        {
            string result = ", ";

            if (App.WrapCells)
            {
                result = Environment.NewLine;
            }

            return result;
        }

    }
}
