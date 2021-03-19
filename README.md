# Serverless ASP.NET Framework Modernization Workshop

This is a workshop to demonstrate how to modernize an ASP.NET REST API service, which runs on expensive, inflexible Windows servers in the cloud, into a resilient, highly scalable serverless service. The approach utilizes the [Strangler Pattern](https://docs.microsoft.com/en-us/azure/architecture/patterns/strangler-fig) to modernize the application piece-by-piece rather than rewrite the entire application all at once.

## What You'll Need

To complete this workshop you will need an [AWS](https://aws.amazon.com/) account, a free [Stackery](https://stackery.io) account, and a few free tools. There are two routes for accessing an AWS account:

* If you are doing this workshop as part of a scheduled AWS Virtual Workshop, you will have access to a free account provisioned for you for use during the workshop. This account will already be running a .NET Framework API using [AWS Elastic Beanstalk](https://aws.amazon.com/elasticbeanstalk/).
* Otherwise, you can use an existing AWS account or open a new one. We'll provision some resources into your account to start a .NET Framework API using [AWS Elastic Beanstalk](https://aws.amazon.com/elasticbeanstalk/). All resource usage fits within the [AWS Free Tier](https://aws.amazon.com/free), so you should not incur any expense running this workshop in a new account. If you run the workshop on an AWS account that does not qualify for the free tier it will cost around $1.03 per day that it is running in your account (this estimate is based on us-east-1 prices).

## Let's get started!

Ready? Let's find out the [backstory of our modernization project](workshop-modules/1-backstory/README.md)