# SignalR Chat App

Real-time chat app written in .NET by following the Microsoft [documentation](https://learn.microsoft.com/en-us/aspnet/core/tutorials/signalr?view=aspnetcore-8.0&tabs=visual-studio).

Client-side opens up a SignalR connection and will receive any chats that get sent while the connection is live. Is also capable of sending chats during the time.


## Possible improvements:

**User Authentication and Authorization:**

Implement user authentication to identify users.
Only allow authenticated users to send messages.

Implement roles and restrict certain actions or areas of the chat to specific roles (e.g., admin-only rooms).

**Persistent Chat History:**

Store chat messages in a database so that users can view chat history when they reconnect or join.
Implement a feature to load previous messages upon entering the chat room.

**Private Messaging:**

Allow users to send private messages to each other, not visible in the main chat room.
Implement a way to list users and initiate a private chat with them.

**Group Rooms:**

Enable the creation of chat rooms or groups where users can join and chat separately from the main channel.
Allow users to create, join, and leave rooms.

**Notifications and Typing Indicators:**

Implement notifications for new messages, especially for private messages or mentions.
Show a typing indicator when a user is composing a message.

**File Sharing:**

Allow users to upload and share files or images in the chat.
Implement restrictions on file size and type for security and performance.

**Message Formatting and Emojis:**

Support for rich text formatting in messages (e.g., bold, italic, links).
Integrate an emoji picker and allow emojis in messages.

**Real-time User Status:**

Show which users are online, offline, or busy.
Update the user status in real-time as users come and go.

**Scalability Improvements:**

Implement ways to scale the chat application for a large number of users, such as using Azure SignalR Service.

**Unit and Integration Tests:**

Write unit tests for your hubs, services, and other parts of the application.
Write integration tests that simulate client-server interactions.
