import 'package:flutter/material.dart';

class Chatscreen extends StatefulWidget {
  final String imgPath;
  final String name;
  final List<Map<String, dynamic>> messages;

  const Chatscreen({super.key, required this.imgPath, required this.name, required this.messages});

  @override
  State<Chatscreen> createState() => _ChatscreenState();
}

class _ChatscreenState extends State<Chatscreen> {
  final TextEditingController _messageController = TextEditingController();
  late List<Map<String, dynamic>> chatMessages;

  @override
  void initState() {
    super.initState();
    chatMessages = List<Map<String, dynamic>>.from(widget.messages);
  }

  void _sendMessage() {
    final text = _messageController.text.trim();
    if (text.isEmpty) return;

    setState(() {
      chatMessages.add({"text": text, "time": "الآن", "isMe": true});
      _messageController.clear();
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.black,
      appBar: AppBar(
        backgroundColor: const Color.fromARGB(255, 1, 14, 3),
        leading: IconButton(
          onPressed: () {
            Navigator.pop(context);
          },
          icon: const Icon(Icons.arrow_back_ios_rounded, color: Colors.white),
        ),
        title: Row(
          children: [
            Expanded(
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.end,
                children: [
                  Text(widget.name, style: const TextStyle(color: Colors.white, fontSize: 18)),
                  const SizedBox(height: 2),
                  const Text('آخر ظهور قبل دقائق', style: TextStyle(color: Colors.white70, fontSize: 12)),
                ],
              ),
            ),
            const SizedBox(width: 12),
            CircleAvatar(
              radius: 20,
              backgroundImage: AssetImage(widget.imgPath),
              backgroundColor: Colors.grey.shade800,
            ),
          ],
        ),
        actions: [
          IconButton(onPressed: () {}, icon: const Icon(Icons.call, color: Colors.white)),
          IconButton(onPressed: () {}, icon: const Icon(Icons.video_call, color: Colors.white)),
          IconButton(onPressed: () {}, icon: const Icon(Icons.more_vert, color: Colors.white)),
        ],
      ),
      body: Column(
        children: [
          Expanded(
            child: ListView.builder(
              padding: const EdgeInsets.symmetric(vertical: 16, horizontal: 12),
              itemCount: chatMessages.length,
              itemBuilder: (context, index) {
                final message = chatMessages[index];
                final isMe = message['isMe'] as bool? ?? false;
                return Align(
                  alignment: isMe ? Alignment.centerRight : Alignment.centerLeft,
                  child: Container(
                    margin: const EdgeInsets.symmetric(vertical: 6),
                    padding: const EdgeInsets.symmetric(vertical: 10, horizontal: 14),
                    decoration: BoxDecoration(
                      color: isMe ? Colors.green.shade700 : const Color.fromARGB(255, 57, 57, 56),
                      borderRadius: BorderRadius.only(
                        topLeft: const Radius.circular(16),
                        topRight: const Radius.circular(16),
                        bottomLeft: Radius.circular(isMe ? 16 : 0),
                        bottomRight: Radius.circular(isMe ? 0 : 16),
                      ),
                    ),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          message['text'] as String,
                          textAlign: TextAlign.right,
                          style: const TextStyle(color: Colors.white, fontSize: 16),
                        ),
                        const SizedBox(height: 6),
                        Text(
                          message['time'] as String,
                          style: const TextStyle(color: Colors.white70, fontSize: 11),
                        ),
                      ],
                    ),
                  ),
                );
              },
            ),
          ),
          Container(
            padding: const EdgeInsets.symmetric(horizontal: 12, vertical: 10),
            color: const Color.fromARGB(255, 18, 18, 18),
            child: Row(
              children: [
                IconButton(onPressed: () {}, icon: const Icon(Icons.attach_file, color: Colors.white70)),
                Expanded(
                  child: Container(
                    padding: const EdgeInsets.symmetric(horizontal: 12),
                    decoration: BoxDecoration(
                      color: const Color.fromARGB(255, 51, 51, 51),
                      borderRadius: BorderRadius.circular(24),
                    ),
                    child: Row(
                      children: [
                        Expanded(
                          child: TextField(
                            controller: _messageController,
                            style: const TextStyle(color: Colors.white),
                            textAlign: TextAlign.right,
                            decoration: const InputDecoration(
                              hintText: 'اكتب رسالة',
                              hintStyle: TextStyle(color: Colors.white60),
                              border: InputBorder.none,
                            ),
                          ),
                        ),
                        IconButton(onPressed: () {}, icon: const Icon(Icons.camera_alt, color: Colors.white70)),
                      ],
                    ),
                  ),
                ),
                const SizedBox(width: 8),
                CircleAvatar(
                  backgroundColor: Colors.green,
                  child: IconButton(
                    onPressed: _sendMessage,
                    icon: const Icon(Icons.send, color: Colors.white),
                  ),
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}
