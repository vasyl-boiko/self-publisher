import { GET_AUTORS_SUCCESS, GET_AUTORS_ERROR } from './autorConstants.jsx'
import "isomorphic-fetch"

export function getAutors(pageIndex = 0) {
    return (dispatch) => {
        let queryTrailer = '?pageIndex=' + pageIndex;
        fetch(constants.page + queryTrailer)
            .then((response) => {
                return response.json()
            }).then((data) => {
                dispatch({ type: GET_AUTORS_SUCCESS, payload: data })
            }).catch((ex) => {
                dispatch({ type: GET_AUTORS_ERROR, payload: ex })
            });
    }
}