import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_user.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/user_service.dart';
import 'package:shared_preferences/shared_preferences.dart';

class AppUserService {
  static var userService = UserService();
  static final Future<SharedPreferences> _prefs = SharedPreferences.getInstance();

  static Future<bool> refreshUserProfile() async {
    APIService.username = await AppUserService.username;
    APIService.password = await AppUserService.password;

    var currentUser = await userService.getMyProfile();

    if (currentUser.userId == null) {
      return false;
    }

    final SharedPreferences prefs = await _prefs;
    prefs.setString('username', currentUser.email ?? '');
    prefs.setInt('userId', currentUser.userId ?? 0);
    prefs.setInt('userRoleId', currentUser.userRoleId ?? 0);
    prefs.setInt('membershipTypeId', currentUser.membershipTypeId ?? 0);
    prefs.setString('membershipType', currentUser.membershipType?.title ?? 'Basic');
    prefs.setString('gender', currentUser.gender ?? 'M');
    prefs.setString('birthDate', currentUser.birthDate ?? '');
    prefs.setString('firstName', currentUser.firstName ?? '');
    prefs.setString('lastName', currentUser.lastName ?? '');
    prefs.setInt('credit', currentUser.credit ?? 0);

    return true;
  }

  static Future<bool> login(String username, String password) async {
    final SharedPreferences prefs = await _prefs;
    prefs.setString('username', username ?? '');
    prefs.setString('password', password ?? '');
    APIService.username = username;
    APIService.password = password;
    var result = await refreshUserProfile();
    return result;
  }

  static Future<bool> refreshLoggedInUser() async {
    var prefUsername = await username;
    if (prefUsername.isNotEmpty) {
      refreshUserProfile();
      return true;
    }
    return false;
  }

  static Future<bool> isUserLoggedIn() async {
    var prefUsername = await username;
    if (prefUsername.isNotEmpty) {
      return true;
    }
    return false;
  }

  static void logout() async {
    final SharedPreferences prefs = await _prefs;
    prefs.setString('username', '');
    prefs.setString('password', '');
    prefs.setInt('userId', 0);
    APIService.username = '';
    APIService.password = '';
  }

  static Future<int> get userId async {
    final SharedPreferences prefs = await _prefs;
    return prefs.getInt('userId') ?? 0;
  }

  static Future<int> get userRoleId async {
    final SharedPreferences prefs = await _prefs;
    return prefs.getInt('userRoleId') ?? 0;
  }

  static Future<int> get membershipTypeId async {
    final SharedPreferences prefs = await _prefs;
    return prefs.getInt('membershipTypeId') ?? 0;
  }

  static Future<int> get credit async {
    final SharedPreferences prefs = await _prefs;
    return prefs.getInt('credit') ?? 0;
  }

  static Future<String> get username async {
    final SharedPreferences prefs = await _prefs;
    return prefs.getString('username') ?? '';
  }

  static Future<String> get password async {
    final SharedPreferences prefs = await _prefs;
    return prefs.getString('password') ?? '';
  }

  static Future<String> get membershipType async {
    final SharedPreferences prefs = await _prefs;
    return prefs.getString('membershipType') ?? '';
  }

  static Future<String> get gender async {
    final SharedPreferences prefs = await _prefs;
    return prefs.getString('gender') ?? '';
  }

  static Future<String> get birthDate async {
    final SharedPreferences prefs = await _prefs;
    return prefs.getString('birthDate') ?? '';
  }

  static Future<String> get firstName async {
    final SharedPreferences prefs = await _prefs;
    return prefs.getString('firstName') ?? '';
  }

  static Future<String> get lastName async {
    final SharedPreferences prefs = await _prefs;
    return prefs.getString('lastName') ?? '';
  }
}
