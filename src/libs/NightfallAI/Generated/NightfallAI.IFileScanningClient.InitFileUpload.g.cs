#nullable enable

namespace NightfallAI
{
    public partial interface IFileScanningClient
    {
        /// <summary>
        /// Initialize a file upload session<br/>
        /// Initializes a file upload session for asynchronous file scanning.<br/>
        /// Returns an upload ID, chunk size, and other metadata needed to upload file chunks.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::NightfallAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::NightfallAI.InitFileUploadResponse> InitFileUploadAsync(

            global::NightfallAI.InitFileUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initialize a file upload session<br/>
        /// Initializes a file upload session for asynchronous file scanning.<br/>
        /// Returns an upload ID, chunk size, and other metadata needed to upload file chunks.
        /// </summary>
        /// <param name="fileSizeBytes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::NightfallAI.InitFileUploadResponse> InitFileUploadAsync(
            long fileSizeBytes,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}