// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GalleryImagesOperations.
    /// </summary>
    public static partial class GalleryImagesOperationsExtensions
    {
            /// <summary>
            /// List gallery images in a given lab account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labAccountName'>
            /// The name of the lab Account.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<GalleryImage> List(this IGalleryImagesOperations operations, string resourceGroupName, string labAccountName, ODataQuery<GalleryImage> odataQuery = default(ODataQuery<GalleryImage>))
            {
                return operations.ListAsync(resourceGroupName, labAccountName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List gallery images in a given lab account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labAccountName'>
            /// The name of the lab Account.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GalleryImage>> ListAsync(this IGalleryImagesOperations operations, string resourceGroupName, string labAccountName, ODataQuery<GalleryImage> odataQuery = default(ODataQuery<GalleryImage>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, labAccountName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get gallery image
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labAccountName'>
            /// The name of the lab Account.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example: 'properties($select=author)'
            /// </param>
            public static GalleryImage Get(this IGalleryImagesOperations operations, string resourceGroupName, string labAccountName, string galleryImageName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, labAccountName, galleryImageName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get gallery image
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labAccountName'>
            /// The name of the lab Account.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example: 'properties($select=author)'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImage> GetAsync(this IGalleryImagesOperations operations, string resourceGroupName, string labAccountName, string galleryImageName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, labAccountName, galleryImageName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing Gallery Image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labAccountName'>
            /// The name of the lab Account.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image.
            /// </param>
            /// <param name='galleryImage'>
            /// Represents an image from the Azure Marketplace
            /// </param>
            public static GalleryImage CreateOrUpdate(this IGalleryImagesOperations operations, string resourceGroupName, string labAccountName, string galleryImageName, GalleryImage galleryImage)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, labAccountName, galleryImageName, galleryImage).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing Gallery Image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labAccountName'>
            /// The name of the lab Account.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image.
            /// </param>
            /// <param name='galleryImage'>
            /// Represents an image from the Azure Marketplace
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImage> CreateOrUpdateAsync(this IGalleryImagesOperations operations, string resourceGroupName, string labAccountName, string galleryImageName, GalleryImage galleryImage, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, labAccountName, galleryImageName, galleryImage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete gallery image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labAccountName'>
            /// The name of the lab Account.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image.
            /// </param>
            public static void Delete(this IGalleryImagesOperations operations, string resourceGroupName, string labAccountName, string galleryImageName)
            {
                operations.DeleteAsync(resourceGroupName, labAccountName, galleryImageName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete gallery image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labAccountName'>
            /// The name of the lab Account.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IGalleryImagesOperations operations, string resourceGroupName, string labAccountName, string galleryImageName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, labAccountName, galleryImageName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Modify properties of gallery images.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labAccountName'>
            /// The name of the lab Account.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image.
            /// </param>
            /// <param name='galleryImage'>
            /// Represents an image from the Azure Marketplace
            /// </param>
            public static GalleryImage Update(this IGalleryImagesOperations operations, string resourceGroupName, string labAccountName, string galleryImageName, GalleryImageFragment galleryImage)
            {
                return operations.UpdateAsync(resourceGroupName, labAccountName, galleryImageName, galleryImage).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modify properties of gallery images.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labAccountName'>
            /// The name of the lab Account.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image.
            /// </param>
            /// <param name='galleryImage'>
            /// Represents an image from the Azure Marketplace
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImage> UpdateAsync(this IGalleryImagesOperations operations, string resourceGroupName, string labAccountName, string galleryImageName, GalleryImageFragment galleryImage, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, labAccountName, galleryImageName, galleryImage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List gallery images in a given lab account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<GalleryImage> ListNext(this IGalleryImagesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List gallery images in a given lab account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GalleryImage>> ListNextAsync(this IGalleryImagesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}