/* 
 * Cohesity REST API
 *
 * This API provides operations for interfacing with the Cohesity Cluster. NOTE: To view the documentation on the responses, click 'Model' next to 'Example Value' and keep clicking to expand the hierarchy.
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ProtectionSourcesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProtectionSourcesApiTests
    {
        private ProtectionSourcesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProtectionSourcesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProtectionSourcesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProtectionSourcesApi
            //Assert.IsInstanceOfType(typeof(ProtectionSourcesApi), instance, "instance is a ProtectionSourcesApi");
        }

        
        /// <summary>
        /// Test GetProtectionSourcesObjectById
        /// </summary>
        [Test]
        public void GetProtectionSourcesObjectByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetProtectionSourcesObjectById(id);
            //Assert.IsInstanceOf<ProtectionSource> (response, "response is ProtectionSource");
        }
        
        /// <summary>
        /// Test GetProtectionSourcesObjects
        /// </summary>
        [Test]
        public void GetProtectionSourcesObjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<long?> objectIds = null;
            //var response = instance.GetProtectionSourcesObjects(objectIds);
            //Assert.IsInstanceOf<List<ProtectionSource>> (response, "response is List<ProtectionSource>");
        }
        
        /// <summary>
        /// Test ListApplicationServers
        /// </summary>
        [Test]
        public void ListApplicationServersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? protectionSourcesRootNodeId = null;
            //string environment = null;
            //string application = null;
            //var response = instance.ListApplicationServers(protectionSourcesRootNodeId, environment, application);
            //Assert.IsInstanceOf<List<RegisteredApplicationServer>> (response, "response is List<RegisteredApplicationServer>");
        }
        
        /// <summary>
        /// Test ListProtectedVms
        /// </summary>
        [Test]
        public void ListProtectedVmsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string environment = null;
            //long? id = null;
            //var response = instance.ListProtectedVms(environment, id);
            //Assert.IsInstanceOf<List<ProtectedVmInfo>> (response, "response is List<ProtectedVmInfo>");
        }
        
        /// <summary>
        /// Test ListProtectionSources
        /// </summary>
        [Test]
        public void ListProtectionSourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? includeDatastores = null;
            //bool? includeNetworks = null;
            //bool? includeVMFolders = null;
            //List<string> environments = null;
            //string environment = null;
            //long? id = null;
            //List<string> excludeTypes = null;
            //var response = instance.ListProtectionSources(includeDatastores, includeNetworks, includeVMFolders, environments, environment, id, excludeTypes);
            //Assert.IsInstanceOf<List<ProtectionSourceNode>> (response, "response is List<ProtectionSourceNode>");
        }
        
        /// <summary>
        /// Test ListProtectionSourcesRegistrationInfo
        /// </summary>
        [Test]
        public void ListProtectionSourcesRegistrationInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> viewNames = null;
            //List<string> environments = null;
            //List<long?> ids = null;
            //var response = instance.ListProtectionSourcesRegistrationInfo(viewNames, environments, ids);
            //Assert.IsInstanceOf<GetRegistrationInfoResponse> (response, "response is GetRegistrationInfoResponse");
        }
        
        /// <summary>
        /// Test ListProtectionSourcesRootNodes
        /// </summary>
        [Test]
        public void ListProtectionSourcesRootNodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //List<string> environments = null;
            //string environment = null;
            //var response = instance.ListProtectionSourcesRootNodes(id, environments, environment);
            //Assert.IsInstanceOf<List<ProtectionSourceNode>> (response, "response is List<ProtectionSourceNode>");
        }
        
        /// <summary>
        /// Test ListSqlAagHostsAndDatabases
        /// </summary>
        [Test]
        public void ListSqlAagHostsAndDatabasesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<long?> sqlProtectionSourceIds = null;
            //var response = instance.ListSqlAagHostsAndDatabases(sqlProtectionSourceIds);
            //Assert.IsInstanceOf<List<SqlAagHostAndDatabases>> (response, "response is List<SqlAagHostAndDatabases>");
        }
        
        /// <summary>
        /// Test ListVirtualMachines
        /// </summary>
        [Test]
        public void ListVirtualMachinesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? vCenterId = null;
            //List<string> names = null;
            //List<string> uuids = null;
            //bool? _protected = null;
            //var response = instance.ListVirtualMachines(vCenterId, names, uuids, _protected);
            //Assert.IsInstanceOf<List<ProtectionSource>> (response, "response is List<ProtectionSource>");
        }
        
        /// <summary>
        /// Test RefreshProtectionSourceById
        /// </summary>
        [Test]
        public void RefreshProtectionSourceByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.RefreshProtectionSourceById(id);
            
        }
        
        /// <summary>
        /// Test RegisterApplicationServers
        /// </summary>
        [Test]
        public void RegisterApplicationServersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RegisterApplicationServersParameters body = null;
            //var response = instance.RegisterApplicationServers(body);
            //Assert.IsInstanceOf<ProtectionSource> (response, "response is ProtectionSource");
        }
        
        /// <summary>
        /// Test RegisterProtectionSource
        /// </summary>
        [Test]
        public void RegisterProtectionSourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RegisterProtectionSourceParameters body = null;
            //var response = instance.RegisterProtectionSource(body);
            //Assert.IsInstanceOf<ProtectionSource> (response, "response is ProtectionSource");
        }
        
        /// <summary>
        /// Test UnregisterApplicationServers
        /// </summary>
        [Test]
        public void UnregisterApplicationServersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.UnregisterApplicationServers(id);
            //Assert.IsInstanceOf<ProtectionSource> (response, "response is ProtectionSource");
        }
        
        /// <summary>
        /// Test UpdateApplicationServers
        /// </summary>
        [Test]
        public void UpdateApplicationServersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateApplicationServerParameters body = null;
            //var response = instance.UpdateApplicationServers(body);
            //Assert.IsInstanceOf<ProtectionSource> (response, "response is ProtectionSource");
        }
        
        /// <summary>
        /// Test UpgradePhysicalAgents
        /// </summary>
        [Test]
        public void UpgradePhysicalAgentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpgradePhysicalServerAgents body = null;
            //var response = instance.UpgradePhysicalAgents(body);
            //Assert.IsInstanceOf<UpgradePhysicalAgentsMessage> (response, "response is UpgradePhysicalAgentsMessage");
        }
        
    }

}