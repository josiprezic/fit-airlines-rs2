import 'package:fit_airlines_mobile_flutter/views/dialogs/logout_alert_dialog.dart';
import 'package:flutter/material.dart';

class FitDrawer {
  Drawer getView(BuildContext context) {
    return Drawer(
      child: ListView(
        children: [
          DrawerHeader(
            child: Text('My drawer header'),
            decoration: BoxDecoration(color: Colors.blue),
          ),
          ListTile(
            leading: Icon(Icons.airplane_ticket),
            title: Text('My Flights'),
            onTap: () {
              Navigator.pop(context);
              Navigator.of(context).pushNamed('/my_flights');
            },
          ),
          ListTile(
            leading: Icon(Icons.auto_graph),
            title: Text('My Stats'),
            onTap: () {
              Navigator.pop(context);
              Navigator.of(context).pushNamed('/stats');
            },
          ),
          ListTile(
            leading: Icon(Icons.person),
            title: Text('My Profile'),
            onTap: () {
              Navigator.pop(context);
              Navigator.of(context).pushNamed('/profile');
            },
          ),
          ListTile(
            leading: Icon(Icons.settings),
            title: Text('Settings'),
            onTap: () {
              Navigator.pop(context);
              Navigator.of(context).pushNamed('/settings');
            },
          ),
          ListTile(
            leading: Icon(Icons.info),
            title: Text('About FIT'),
            onTap: () {
              Navigator.pop(context);
              Navigator.of(context).pushNamed('/about');
            },
          ),
          ListTile(
            leading: Icon(Icons.logout),
            title: Text('Logout'),
            onTap: () {
              Navigator.pop(context);
              showLogoutAlertDialog(context);
            },
          ),
        ],
      ),
    );
  }
}
