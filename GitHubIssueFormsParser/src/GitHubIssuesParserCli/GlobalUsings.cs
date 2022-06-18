global using System.Diagnostics.CodeAnalysis;
global using System.Runtime.CompilerServices;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using CliFx;
global using CliFx.Attributes;
global using CliFx.Exceptions;
global using CliFx.Extensibility;
global using CliFx.Infrastructure;
global using GitHubIssuesParserCli.ArgumentValidations;
global using GitHubIssuesParserCli.IssueFormBody;
global using GitHubIssuesParserCli.IssueFormBody.IssueFormItems;
global using GitHubIssuesParserCli.IssueFormBody.IssueFormItems.Checkboxes;
global using GitHubIssuesParserCli.IssueFormBody.IssueFormItems.Text;
global using GitHubIssuesParserCli.IssueFormBody.JsonSerialization;
global using GitHubIssuesParserCli.IssueFormBody.Parsing;
global using GitHubIssuesParserCli.IssueFormTemplates;
global using GitHubIssuesParserCli.IssueFormTemplates.Parsing;
global using SlugGenerator;
global using YamlDotNet.Core;
global using YamlDotNet.Serialization;
