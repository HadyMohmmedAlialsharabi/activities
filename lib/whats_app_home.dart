
import 'package:flutter/material.dart';
import 'package:whats_app_clone/chat_summary_widget.dart';
import 'package:whats_app_clone/custom_search_widget.dart';

class WhatsAppHome extends StatefulWidget {
  const WhatsAppHome({super.key});

  @override
  State<WhatsAppHome> createState() => _WhatsAppHomeState();
}

class _WhatsAppHomeState extends State<WhatsAppHome> {
List<Map<String, dynamic>> chatList = [
  {
    "name": "Ali",
    "lastMssg": "السلام عليكم، كيف حالك؟",
    "time": "5:01",
    "imagePath": "assets/images/image_1.jpg",
    "messages": [
      {"text": "السلام عليكم", "time": "5:00", "isMe": false},
      {"text": "وعليكم السلام، بخير الحمد لله", "time": "5:01", "isMe": true},
      {"text": "كيف كان يومك؟", "time": "5:02", "isMe": false},
    ],
  },
  {
    "name": "Ahmed",
    "lastMssg": "تمام، انت كيف؟",
    "time": "4:45",
    "imagePath": "assets/images/image_2.jpg",
    "messages": [
      {"text": "مرحبا يا أحمد!", "time": "4:43", "isMe": false},
      {"text": "مرحباً، بخير الحمد لله", "time": "4:45", "isMe": true},
    ],
  },
  {
    "name": "Mona",
    "lastMssg": "أرسل لي الصورة لو سمحت.",
    "time": "3:20",
    "imagePath": "assets/images/image_3.jpg",
    "messages": [
      {"text": "أرسل لي الصورة لو سمحت.", "time": "3:18", "isMe": false},
      {"text": "حاضر، أرسلها الآن.", "time": "3:20", "isMe": true},
    ],
  },
];

int _mssgCount = 0;
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        backgroundColor: Colors.black,
        appBar: AppBar(
          bottom: const PreferredSize(
              preferredSize: Size.fromHeight(100),
              child: CustomSearchWidget()),
          leadingWidth: 100,
          leading: const Padding(
            padding: EdgeInsets.only(left: 16),
            child: Row(
              children: [
                Icon(
                  Icons.more_vert,
                  color: Colors.white,
                ),
                SizedBox(
                  width: 10,
                ),
                Icon(
                  Icons.camera_alt_outlined,
                  color: Colors.white,
                )
              ],
            ),
          ),
          title: Container(
            padding: const EdgeInsets.only(right: 16.0),
            alignment: Alignment.centerRight,
            child: const Text(
              "واتساب",
              style: TextStyle(color: Colors.white),
            ),
          ),
          backgroundColor: Colors.black,
        ),
        body: ListView.builder(
          itemCount: chatList.length,
          itemBuilder: (context, index) {
            return ChatSummaryWidget(
              name: chatList[index]["name"],
              lastMessage: chatList[index]["lastMssg"],
              time: chatList[index]["time"],
              imagePath: chatList[index]["imagePath"],
              messages: List<Map<String, dynamic>>.from(chatList[index]["messages"]),
              mssgCount: _mssgCount,
            );
          },
        ) 
        

      
        ,
        floatingActionButton: FloatingActionButton(
          backgroundColor: Colors.green,
          onPressed: () {
            setState(() {
              _mssgCount++;
            });
          },
          child: const Icon(
            Icons.add_comment,
            color: Colors.white,
          ),
        ),
        floatingActionButtonLocation: FloatingActionButtonLocation.startFloat,
        bottomNavigationBar: BottomNavigationBar(
            unselectedItemColor: Colors.white,
            selectedItemColor: Colors.green,
            backgroundColor: Colors.black,
            currentIndex: 1,
            type: BottomNavigationBarType.fixed,
            items: const [
              BottomNavigationBarItem(
                  icon: Icon(Icons.call), label: "المكالمات"),
              BottomNavigationBarItem(
                  icon: Icon(Icons.groups_3_outlined), label: "المجتمعات"),
              BottomNavigationBarItem(
                  icon: Icon(Icons.refresh), label: "التحديثات"),
              BottomNavigationBarItem(
                  icon: Icon(Icons.comment), label: "الدردشات"),
            ]),
      ),
      debugShowCheckedModeBanner: false,
    );
  }
}
