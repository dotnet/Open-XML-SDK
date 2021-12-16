# Document Task

The sample code shows how to add a DocumentTask to an Excel file with the SDK.

The important methods in Program.cs are:
```csharp
// add a new task to a document
private static void AddNewTask(MainDocumentPart mdp, string title, User assignee, User assigner)

// Add a new paragraph with a comment
private static void AddNewParagraphRunWithComment(MainDocumentPart mdp, string strCommentId, string strParagraphText)

// Add a comment that mentions another user
private static void AddMentionComment(MainDocumentPart mdp, string strCommentId, string mention, string commentText, User mentioner, User mentionee, RandomParagraphIdGenerator pIdGener)
```
