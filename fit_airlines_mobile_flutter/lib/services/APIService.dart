import 'dart:convert';
import 'package:http/http.dart' as http;

class APIService {
  static String username = '';
  static String password = '';
  String route;

  APIService({required this.route});

  void setParameter(String username, String password) {
    APIService.username = username;
    APIService.password = password;
  }

  static Future<List?> get(String route) async {
    String baseUrl = 'http://172.25.208.1:25001/api/Countries';
    //String baseUrl =
    //    'http://192.168.0.171:2137/api/airports'; // + route; // TODO: Szef base url
    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));

    final response = await http.get(
      Uri.parse(baseUrl),
      //headers: {HttpHeaders.authorizationHeader: basicAuth}
    );

    if (response.statusCode == 200) {
      print('WOOOHOOOO');
      var responseeee = JsonDecoder().convert(response.body);
      print(responseeee);
      return responseeee;
    } else {
      print('DUPA DUPA');
      print(response.statusCode);
      print(response.body);
      //return ''; // TODO: JR
      return null;
    }
  }
}
