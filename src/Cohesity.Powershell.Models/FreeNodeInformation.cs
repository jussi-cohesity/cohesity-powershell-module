// Copyright 2019 Cohesity Inc.

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cohesity.Model
{
    /// <summary>
    /// Specifies the Metadata of a free Node on the network.
    /// </summary>
    [DataContract]
    public partial class FreeNodeInformation :  IEquatable<FreeNodeInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FreeNodeInformation" /> class.
        /// </summary>
        /// <param name="chassisSerial">Specifies the serial number of the Chassis the Node is installed in..</param>
        /// <param name="connectedTo">Specifies whether or not this is the Node that is sending the response..</param>
        /// <param name="id">Specifies the ID of the node..</param>
        /// <param name="ip">Specifies the IP address of the Node..</param>
        /// <param name="ipmiIp">Specifies the IPMI IP of the Node..</param>
        /// <param name="nodeSerial">Specifies the serial number of the Node..</param>
        /// <param name="nodeUiSlot">Specifies the postition for the UI to display the Node in the Cluster creation page..</param>
        /// <param name="numSlotsInChassis">Specifies the number of Node slots present in the Chassis where this Node is installed..</param>
        /// <param name="slotNumber">Specifies the number of the slot the Node is installed in..</param>
        /// <param name="softwareVersion">Specifies the version of the software installed on the Node..</param>
        public FreeNodeInformation(string chassisSerial = default(string), bool? connectedTo = default(bool?), long? id = default(long?), string ip = default(string), string ipmiIp = default(string), string nodeSerial = default(string), string nodeUiSlot = default(string), int? numSlotsInChassis = default(int?), string slotNumber = default(string), string softwareVersion = default(string))
        {
            this.ChassisSerial = chassisSerial;
            this.ConnectedTo = connectedTo;
            this.Id = id;
            this.Ip = ip;
            this.IpmiIp = ipmiIp;
            this.NodeSerial = nodeSerial;
            this.NodeUiSlot = nodeUiSlot;
            this.NumSlotsInChassis = numSlotsInChassis;
            this.SlotNumber = slotNumber;
            this.SoftwareVersion = softwareVersion;
            this.ChassisSerial = chassisSerial;
            this.ConnectedTo = connectedTo;
            this.Id = id;
            this.Ip = ip;
            this.IpmiIp = ipmiIp;
            this.NodeSerial = nodeSerial;
            this.NodeUiSlot = nodeUiSlot;
            this.NumSlotsInChassis = numSlotsInChassis;
            this.SlotNumber = slotNumber;
            this.SoftwareVersion = softwareVersion;
        }
        
        /// <summary>
        /// Specifies the serial number of the Chassis the Node is installed in.
        /// </summary>
        /// <value>Specifies the serial number of the Chassis the Node is installed in.</value>
        [DataMember(Name="chassisSerial", EmitDefaultValue=true)]
        public string ChassisSerial { get; set; }

        /// <summary>
        /// Specifies whether or not this is the Node that is sending the response.
        /// </summary>
        /// <value>Specifies whether or not this is the Node that is sending the response.</value>
        [DataMember(Name="connectedTo", EmitDefaultValue=true)]
        public bool? ConnectedTo { get; set; }

        /// <summary>
        /// Specifies the ID of the node.
        /// </summary>
        /// <value>Specifies the ID of the node.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the IP address of the Node.
        /// </summary>
        /// <value>Specifies the IP address of the Node.</value>
        [DataMember(Name="ip", EmitDefaultValue=true)]
        public string Ip { get; set; }

        /// <summary>
        /// Specifies the IPMI IP of the Node.
        /// </summary>
        /// <value>Specifies the IPMI IP of the Node.</value>
        [DataMember(Name="ipmiIp", EmitDefaultValue=true)]
        public string IpmiIp { get; set; }

        /// <summary>
        /// Specifies the serial number of the Node.
        /// </summary>
        /// <value>Specifies the serial number of the Node.</value>
        [DataMember(Name="nodeSerial", EmitDefaultValue=true)]
        public string NodeSerial { get; set; }

        /// <summary>
        /// Specifies the postition for the UI to display the Node in the Cluster creation page.
        /// </summary>
        /// <value>Specifies the postition for the UI to display the Node in the Cluster creation page.</value>
        [DataMember(Name="nodeUiSlot", EmitDefaultValue=true)]
        public string NodeUiSlot { get; set; }

        /// <summary>
        /// Specifies the number of Node slots present in the Chassis where this Node is installed.
        /// </summary>
        /// <value>Specifies the number of Node slots present in the Chassis where this Node is installed.</value>
        [DataMember(Name="numSlotsInChassis", EmitDefaultValue=true)]
        public int? NumSlotsInChassis { get; set; }

        /// <summary>
        /// Specifies the number of the slot the Node is installed in.
        /// </summary>
        /// <value>Specifies the number of the slot the Node is installed in.</value>
        [DataMember(Name="slotNumber", EmitDefaultValue=true)]
        public string SlotNumber { get; set; }

        /// <summary>
        /// Specifies the version of the software installed on the Node.
        /// </summary>
        /// <value>Specifies the version of the software installed on the Node.</value>
        [DataMember(Name="softwareVersion", EmitDefaultValue=true)]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() { return ToJson(); }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FreeNodeInformation);
        }

        /// <summary>
        /// Returns true if FreeNodeInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of FreeNodeInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FreeNodeInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChassisSerial == input.ChassisSerial ||
                    (this.ChassisSerial != null &&
                    this.ChassisSerial.Equals(input.ChassisSerial))
                ) && 
                (
                    this.ConnectedTo == input.ConnectedTo ||
                    (this.ConnectedTo != null &&
                    this.ConnectedTo.Equals(input.ConnectedTo))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.IpmiIp == input.IpmiIp ||
                    (this.IpmiIp != null &&
                    this.IpmiIp.Equals(input.IpmiIp))
                ) && 
                (
                    this.NodeSerial == input.NodeSerial ||
                    (this.NodeSerial != null &&
                    this.NodeSerial.Equals(input.NodeSerial))
                ) && 
                (
                    this.NodeUiSlot == input.NodeUiSlot ||
                    (this.NodeUiSlot != null &&
                    this.NodeUiSlot.Equals(input.NodeUiSlot))
                ) && 
                (
                    this.NumSlotsInChassis == input.NumSlotsInChassis ||
                    (this.NumSlotsInChassis != null &&
                    this.NumSlotsInChassis.Equals(input.NumSlotsInChassis))
                ) && 
                (
                    this.SlotNumber == input.SlotNumber ||
                    (this.SlotNumber != null &&
                    this.SlotNumber.Equals(input.SlotNumber))
                ) && 
                (
                    this.SoftwareVersion == input.SoftwareVersion ||
                    (this.SoftwareVersion != null &&
                    this.SoftwareVersion.Equals(input.SoftwareVersion))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ChassisSerial != null)
                    hashCode = hashCode * 59 + this.ChassisSerial.GetHashCode();
                if (this.ConnectedTo != null)
                    hashCode = hashCode * 59 + this.ConnectedTo.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.IpmiIp != null)
                    hashCode = hashCode * 59 + this.IpmiIp.GetHashCode();
                if (this.NodeSerial != null)
                    hashCode = hashCode * 59 + this.NodeSerial.GetHashCode();
                if (this.NodeUiSlot != null)
                    hashCode = hashCode * 59 + this.NodeUiSlot.GetHashCode();
                if (this.NumSlotsInChassis != null)
                    hashCode = hashCode * 59 + this.NumSlotsInChassis.GetHashCode();
                if (this.SlotNumber != null)
                    hashCode = hashCode * 59 + this.SlotNumber.GetHashCode();
                if (this.SoftwareVersion != null)
                    hashCode = hashCode * 59 + this.SoftwareVersion.GetHashCode();
                return hashCode;
            }
        }

    }

}

