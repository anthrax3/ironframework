// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeePayHistoryBOTests.cs" company="Megadotnet">
// Copyright (c) 2010-2015 Peter Liu.  All rights reserved. 
// </copyright>
// <summary>
//   The EmployeePayHistoryTests
//   This file is auto generated and will be overwritten as soon as the template is executed
//   Do not modify this file...
// </summary>
// --------------------------------------------------------------------------------------------------------------------	
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using BusinessEntities;
using Xunit;
using Xunit.Extensions;
using Ploeh.AutoFixture.Xunit;
using System.Threading.Tasks;
using DataTransferObject;
using BusinessObject;
using DataAccessObject;
	
namespace UnitTest.GenreateBOTests
{   
    /// <summary>
    /// EmployeePayHistory Tests object
    /// </summary>
	public partial class EmployeePayHistoryBOTests
	{       
        #region BoTest

        /// <summary>
        /// Tests the add.
        /// </summary>
        /// <param name="_EmployeePayHistoryDto">The EmployeePayHistory dto.</param>
        [Theory, AutoData, AutoRollback]
        public void TestAdd(EmployeePayHistoryDto _EmployeePayHistoryDto)
        {
            var _EmployeePayHistoryBO = new EmployeePayHistoryBO();
            bool hasAdded=_EmployeePayHistoryBO.CreateEntiy(_EmployeePayHistoryDto);
            Assert.True(hasAdded);
        }

	    /// <summary>
        ///GetEntiyByPK
        /// </summary>
        /// <param name="pkid">The PK int</param>
        [Theory, AutoData]
        public void TestGetEntiyByPK(int pkid)
        {
            var _EmployeePayHistoryBO = new EmployeePayHistoryBO();
            var dbResult = _EmployeePayHistoryBO.GetEntiyByPK(pkid);
            Assert.NotNull(dbResult);
        }

        /// <summary>
        /// Tests the get.
        /// </summary>
        /// <param name="_EmployeePayHistoryDto">The _EmployeePayHistory dto.</param>
        [Theory, AutoData]
        public void TestFindAll(EmployeePayHistoryDto _EmployeePayHistoryDto)
        {
            var _EmployeePayHistoryBO = new EmployeePayHistoryBO();
            var dbResult=_EmployeePayHistoryBO.FindAll(_EmployeePayHistoryDto);
            Assert.NotNull(dbResult);
		    Assert.True(dbResult.Total>0);
        }

		/// <summary>
        /// Tests the get.
        /// </summary>
        /// <param name="_EmployeePayHistoryDto">The _EmployeePayHistory dto.</param>
        [Theory, AutoData]
        public void TestFindEnties(EmployeePayHistoryDto _EmployeePayHistoryDto)
        {
            var _EmployeePayHistoryBO = new EmployeePayHistoryBO();
            var dbResult=_EmployeePayHistoryBO.FindEnties(_EmployeePayHistoryDto);
            Assert.NotNull(dbResult);
			Assert.True(dbResult.Total>0);
        }

        /// <summary>
        /// Tests the get.
        /// </summary>
        /// <param name="_EmployeePayHistoryDto">The _EmployeePayHistory dto.</param>
        [Theory, AutoData]
        public void TestFindEntiesWithSimplePaging(int? pageIndex, int pageSize)
        {
             var _EmployeePayHistoryBO = new EmployeePayHistoryBO();
            var dbResult = _EmployeePayHistoryBO.FindEnties(pageIndex, pageSize);
            Assert.NotNull(dbResult);
			Assert.True(dbResult.Count>0);
        }

		/// <summary>
        /// TestUpdateEntiyWithGet
        /// </summary>
        /// <param name="_EmployeePayHistoryDto"></param>
        [Theory, AutoData, AutoRollback]
        public void TestUpdateEntiyWithGet(EmployeePayHistoryDto _EmployeePayHistoryDto)
        {
            var _EmployeePayHistoryBO = new EmployeePayHistoryBO();
            var dbResult = _EmployeePayHistoryBO.UpdateEntiyWithGet(_EmployeePayHistoryDto);
            Assert.NotNull(dbResult);
        }

        /// <summary>
        /// Tests the update with attach entiy.
        /// </summary>
        /// <param name="_EmployeePayHistoryDto">The EmployeePayHistory.</param>
        [Theory, AutoData, AutoRollback]
        public void TestUpdateWithAttachEntiy(EmployeePayHistoryDto _EmployeePayHistoryDto)
        {
            var _EmployeePayHistoryBO = new EmployeePayHistoryBO();
            bool isUpdated = _EmployeePayHistoryBO.UpdateWithAttachEntiy(_EmployeePayHistoryDto);
            Assert.True(isUpdated);
        }

        /// <summary>
        /// Tests the delete with attach entiy.
        /// </summary>
        /// <param name="_EmployeePayHistoryDto">The EmployeePayHistory dto.</param>
        [Theory, AutoData, AutoRollback]
        public void TestDeleteWithAttachEntiy(EmployeePayHistoryDto _EmployeePayHistoryDto)
        {
            var _EmployeePayHistoryBO = new EmployeePayHistoryBO();
            bool isDeleted = _EmployeePayHistoryBO.DeleteWithAttachEntiy(_EmployeePayHistoryDto);
            Assert.True(isDeleted);
        }

		/// <summary>
        /// TestDeleteEntiy
        /// </summary>
        /// <param name="_EmployeePayHistoryDto">_EmployeePayHistoryDto</param>
        [Theory, AutoData, AutoRollback]
        public void TestDeleteEntiy(EmployeePayHistoryDto _EmployeePayHistoryDto)
        {
            var _EmployeePayHistoryBO = new EmployeePayHistoryBO();
            bool isDeleted = _EmployeePayHistoryBO.DeleteEntiy(_EmployeePayHistoryDto);
            Assert.True(isDeleted);
        }

        #endregion

        /// <summary>
        /// Tests the EmployeePayHistory repository add.
        /// </summary>
        /// <param name="_EmployeePayHistory">The _ EmployeePayHistory.</param>
        [Theory, AutoData, AutoRollback]
        public void TestEmployeePayHistoryRepositoryAdd(EmployeePayHistory _EmployeePayHistory)
        {
            var _EmployeePayHistoryRepository = RepositoryHelper.GetEmployeePayHistoryRepository();
            _EmployeePayHistoryRepository.Add(_EmployeePayHistory);
            _EmployeePayHistoryRepository.Save();
        }

        /// <summary>
        /// Tests the EmployeePayHistory repository get.
        /// </summary>
        /// <param name="_EmployeePayHistoryId">The _ EmployeePayHistory identifier.</param>
        [Theory, AutoData]
        public void TestEmployeePayHistoryRepositoryGet(int  _EmployeePayHistoryId)
        {
            var _EmployeePayHistoryRepository = RepositoryHelper.GetEmployeePayHistoryRepository();
            var _EmployeePayHistory=_EmployeePayHistoryRepository.Repository.Find(entity=>entity.EmployeeID==_EmployeePayHistoryId);
            Assert.NotNull(_EmployeePayHistory);
        }

        /// <summary>
        /// TestEmployeePayHistoryRepositoryFindAsyc
        /// </summary>
        /// <param name="_AddressId"></param>
        /// <returns></returns>
        [Theory, AutoData]
        public async Task<IEnumerable<EmployeePayHistory>> TestEmployeePayHistoryRepositoryFindAsyc(int _EmployeePayHistoryId)
        {
            var _EmployeePayHistoryRepository = RepositoryHelper.GetEmployeePayHistoryRepository();
            var _EmployeePayHistory =await _EmployeePayHistoryRepository.Repository.FindAsync(entity => entity.EmployeeID == _EmployeePayHistoryId);
            Assert.NotNull(_EmployeePayHistory);
            return _EmployeePayHistory;
        }

	}
}