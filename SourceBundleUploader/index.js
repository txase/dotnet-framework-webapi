const fs = require('fs');

const AWS = require('aws-sdk');
const cfnCR = require('cfn-custom-resource');

const s3 = new AWS.S3();

exports.handler = async event => {
  // Log the event argument for debugging and for use in local development.
  console.log(JSON.stringify(event, undefined, 2));

  try {
    switch (event.RequestType) {
      case 'Create':
      case 'Update':
        await s3.upload({
          Body: fs.createReadStream('app.zip'),
          Bucket: process.env.BUCKET_NAME,
          ContentType: 'application/zip',
          Key: 'app.zip',
          ServerSideEncryption: 'aws:kms'
        }).promise();
        break;

      case 'Delete':
        await s3.deleteObject({
          Bucket: process.env.BUCKET_NAME,
          Key: 'app.zip'
        }).promise();
        break;

      default:
        throw new Error(`Unknown CloudFormation Custom Resource RequestType value '${event.RequestType}'`);
    }

    await cfnCR.sendSuccess('app.zip', {}, event);
  } catch (err) {
    await cfnCR.sendFailure(`Failed to upload app.zip to bucket ${process.env.BUCKET_NAME}: ${error.message}`, event);
    throw err;
  }
};
